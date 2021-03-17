using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarsAdded);            
        }

        [SecuredOperation("car.delete,admin")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            
            return new SuccessResult("Ürün Silindi");
        }

        [SecuredOperation("car.getall,admin")]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);         
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == brandId), "marka seçimine göre listelendi");
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), "renk seçimine göre listelendi");
        }

        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),"Araç detayları:");
        }

        [SecuredOperation("car.update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
             _carDal.Update(car);
            return new SuccessResult(Messages.CarsUpdated);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarsUpdated);
        }
    }
}
