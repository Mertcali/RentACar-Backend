using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryBellekteCalismaFonksiyonuMethodu();
            //BeforeCoreLayer();

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Marka\tAraç\tRenk\tGünlükÜcret\tAçıklama");
            Console.WriteLine("--------------------------------------------------RENTACARPROJECT");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "\t" + car.CarName + "\t" + car.ColorName + "\t" + car.DailyPrice + "\t        "  +car.Description  );
            }

        }


        private static void BeforeCoreLayer()
        {
            Console.WriteLine("-----EntityFrameWorkCars-----");

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 500, ModelYear = "2016", Descriptions = "ab" });

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

            Console.WriteLine("-----GetCarDetails-----");

            CarManager carManager2 = new CarManager(new EfCarDal());


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
