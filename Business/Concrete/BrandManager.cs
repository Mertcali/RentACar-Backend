using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("marka eklendi");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("marka silindi");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
            Console.WriteLine("Ürünler listelendi");
        }

        //public List<Brand> GetById(int brandId)
        //{
        //    return _brandDal.GetById(2);
        //    Console.WriteLine(brandId + " idli markalar listelendi");

        //}

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Markalar güncellendi");
        }
    }
}
