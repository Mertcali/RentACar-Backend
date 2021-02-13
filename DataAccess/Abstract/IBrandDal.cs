using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
        //List<Brand> GetById(int brandId);
    }
}
