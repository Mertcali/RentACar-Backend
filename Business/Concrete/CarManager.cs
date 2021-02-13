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
            if (car.Descriptions.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Araç eklenemedi.2 Karakterden daha uzun tanım ve 0'dan büyük günlük fiyat giriniz.");
            }
            
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

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(b => b.BrandId == brandId);
            Console.WriteLine("marka seçimine göre listelendi");
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
            Console.WriteLine("renk seçimine göre listelendi");
        }

        //public List<Car> GetById(int carId)
        //{
        //    return _carDal.GetById(2);
        //    Console.WriteLine(carId + " idsine sahip ürünler listelendi");
        //}

        public void Update(Car car)
        {
             _carDal.Update(car);
            Console.WriteLine("araç güncellendi");
        }
    }
}
