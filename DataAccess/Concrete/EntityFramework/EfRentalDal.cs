using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on r.CarId equals c.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             join u in context.Users on r.UserId equals u.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarDailyPrice=c.DailyPrice,
                                 CarId = c.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CarName = c.CarName,
                                 UserId = u.Id,
                                 BrandName = b.Name,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CarDescription = c.Descriptions,
                                 CarModelYear = c.ModelYear,
                                 ColorName = co.Name,

                                 
                             };
                return result.ToList();
            }
        }
    }
}