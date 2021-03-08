using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             select new RentalDetailDto()
                             {
                                 CarName = c.CarName,
                                 BrandName = b.Name,
                                 DailyPrice = c.DailyPrice,
                                 RentDate = r.RentDate,

                             };
                return result.ToList();

            }

        }
    }
}
