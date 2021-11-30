using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
         
            

        }
    }
}
