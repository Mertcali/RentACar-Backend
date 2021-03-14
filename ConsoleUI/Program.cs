using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Core.Entities.Concrete;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryBellekteCalismaFonksiyonuMethodu();
            //BeforeCoreLayer();
            //CoreLayerodevgun9();
            //gun9listeleme();
            //ColorTest();
            //BrandTest();
            //UserAddTest();
            //CustomerAddTest();
            //RentalAddTest();
            //RentalShowTest();

        }

        private static void RentalShowTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                Console.WriteLine("Marka\tAraç\tGünlükÜcret\tKiraTarihi");
                Console.WriteLine("--------------------------------------------------RENTACARPROJECT");
                foreach (var rent in result.Data)
                {
                    Console.WriteLine(rent.BrandName + "\t" + rent.CarName + "\t" + rent.DailyPrice + "\t" + "\t" + rent.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 2,
                RentDate = new DateTime(2021, 02, 20),
                ReturnDate = null
            });
            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 02, 21),
                ReturnDate = new DateTime(2021, 02, 23)
            });
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1, CompanyName = "MRT HOLDING" });
            customerManager.Add(new Customer { UserId = 2, CompanyName = "KOC HOLDING" });
            customerManager.Add(new Customer { UserId = 3, CompanyName = "ALS HOLDING" });
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Mert",
                LastName = "Cali",
                Email = "mertasa@gmail.com",
                //Password = "1235123"
            });
            userManager.Add(new User
            {
                FirstName = "Omer",
                LastName = "Say",
                Email = "omer1234@gmail.com",
                //Password = "ab123123c"
            });
            userManager.Add(new User
            {
                FirstName = "İsmail",
                LastName = "Murat",
                Email = "isotto@gmail.com",
                //Password = "n3guzelsifre"
            });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Mercedes" });
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Delete(new Brand { Id = 5 });

            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Id + "\t" + brand.Name);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 1, Name = "Beyaz" });
            colorManager.Add(new Color { Id = 2, Name = "Gri" });
            colorManager.Add(new Color { Id = 3, Name = "Mavi" });
            colorManager.Add(new Color { Id=4, Name = "Sari" });
            colorManager.Add(new Color { Id=5, Name = "Turuncu" });
            colorManager.Add(new Color { Id=6, Name = "Yeşil" });
            colorManager.Delete(new Color { Id = 10 });


            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.Id + "\t" + color.Name);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void gun9listeleme()
        {
            Console.WriteLine("Marka\tAraç\tRenk\tGünlükÜcret\tAçıklama");
            Console.WriteLine("--------------------------------------------------RENTACARPROJECT");

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "\t" + car.CarName + "\t" + car.ColorName + "\t" + car.DailyPrice + "\t        " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CoreLayerodevgun9()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Marka\tAraç\tRenk\tGünlükÜcret\tAçıklama");
            Console.WriteLine("--------------------------------------------------RENTACARPROJECT");

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + "\t" + car.CarName + "\t" + car.ColorName + "\t" + car.DailyPrice + "\t        " + car.Description);
            }
        }

        /*
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
        */
    }
}

