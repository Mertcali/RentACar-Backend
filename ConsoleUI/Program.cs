using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryBellekteCalismaFonksiyonuMethodu();

            Console.WriteLine("-----EntityFrameWorkCars-----");

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions);
            }

            Console.WriteLine("-----MARKA SEÇİMİNE GÖRE LİSTELEME-----");

            CarManager carManager1 = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Descriptions);
            }

        

            Console.WriteLine("-----EntityFrameWorkBrands-----");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }


            Console.WriteLine("-----EntityFrameWorkColors-----");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }


        }

        private static void InMemoryBellekteCalismaMethodu()
        {
            //INMEMORY BELLEKTE ÇALIŞTIĞIM CONSOLEUI ÇIKTILARIM

            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + "  idli araba: " + car.Descriptions + " ----" + car.DailyPrice + "  TL");
            }

            Console.WriteLine("--------BRANDS--------");

            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("--------COLORS--------");

            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

        }
    }
}
