using System;
using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdded();
            //CarTest();
            //EfEntityRepositoryBase<Car, RentCarContext> a = new EfEntityRepositoryBase<Car, RentCarContext>();
            //a.Update(new Car{Id = 1, CarName = "Kangoo", DailyPrice = 100, ColorId = 1, Description = "Hususi", BrandId = 3, ModelYear = 2006});
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result1 = carManager.Add(new Car
            {
                Id = 1, CarName = "Rolls", DailyPrice = 1000, ColorId = 2, BrandId = 3, ModelYear = 2021, Description = "Luxury"
            });
            Console.WriteLine(result1.Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
