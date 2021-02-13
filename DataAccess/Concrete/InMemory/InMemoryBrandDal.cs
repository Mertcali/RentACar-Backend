using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Renault"},
                new Brand{BrandId=2,BrandName="Hyundai"},
                new Brand{BrandId=3,BrandName="Porsche"},
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
            Console.WriteLine("Marka eklendi");
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //public List<Brand> GetAll()
        //{
        //    return _brands;
        //}

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        //public List<Brand> GetById(int brandId)
        //{
        //    return _brands.Where(b => b.BrandId == brandId).ToList();
        //}

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(c => c.BrandId == brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;

        }
    }
}
