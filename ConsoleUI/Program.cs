using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = 2021, Description = "Passat" });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Bmw" });

            
        }

        


}
}
