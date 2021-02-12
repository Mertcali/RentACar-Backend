using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2016",DailyPrice=130,Description="Beyaz Renault Symbol Dizel Manuel"},
                new Car{CarId=2,BrandId=1,ColorId=3,ModelYear="2017",DailyPrice=150,Description="Mavi Renault Clio Dizel Manuel"},
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear="2017",DailyPrice=275,Description="Beyaz Hyundai Elantra Dizel Otomatik"},
                new Car{CarId=4,BrandId=2,ColorId=2,ModelYear="2018",DailyPrice=165,Description="Gri Hyundai Accent Dizel Otomatik"},
                new Car{CarId=5,BrandId=3,ColorId=1,ModelYear="2016",DailyPrice=600,Description="Beyaz Porsche Cayenne Benzin Otomatik"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
           return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
