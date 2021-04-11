using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             join f in context.FindexSet
                             on u.Id equals f.UserId
                             select new CustomerDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 UserId = u.Id,
                                 Email = u.Email,
                                 FindexScore = f.FindexScore,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
                
            }
        }
    }
}
