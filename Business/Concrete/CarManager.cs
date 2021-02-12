using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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


        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Araba eklendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("araba silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
            Console.WriteLine("araçlar listelendi");
        }

        public List<Car> GetById(int carId)
        {
            return _carDal.GetById(2);
            Console.WriteLine(carId + " idsine sahip ürünler listelendi");
        }

        public void Update(Car car)
        {
             _carDal.Update(car);
            Console.WriteLine("araç güncellendi");
        }
    }
}
