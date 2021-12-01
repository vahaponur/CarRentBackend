using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { Id=1, DailyPrice = 2000,BrandId=1,ColorId=1, Description = "bir araba", ModelYear = 1995 };
            carManager.Add(car1);

        }
    }
}
