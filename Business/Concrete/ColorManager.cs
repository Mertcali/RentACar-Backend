using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("renk eklendi");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("renk silindi");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
            Console.WriteLine("renkler listelendi");
        }

        //public List<Color> GetById(int colorId)
        //{
        //    return _colorDal.GetById(2);
        //    Console.WriteLine(colorId + " idli renkler listelendi");
        //}

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk güncellendi");
        }
    }
}
