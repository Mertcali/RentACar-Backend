using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {

    public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
    {
        using (RentACarContext context = new RentACarContext())
        {
            var result = from brand in context.Brands
                         join car in context.Cars
                         on brand.Id equals car.BrandId
                         join col in context.Colors
                         on car.ColorId equals col.Id
                         select new CarDetailDto
                         {
                             CarName = car.CarName,
                             CarId = car.Id,
                             BrandName = brand.Name,
                             ColorName = col.Name,
                             DailyPrice = car.DailyPrice,
                             Description = car.Descriptions,
                             ModelYear = car.ModelYear,
                             BrandId = brand.Id,
                             ColorId = col.Id,
                             ImagePath = (from a in context.CarImages where a.CarId == car.Id select a.ImagePath).FirstOrDefault()
                         };

            return filter == null
             ? result.ToList()
             : result.Where(filter).ToList();

        }
    }




}
}
