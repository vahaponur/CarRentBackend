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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color { Id = 5, Name = "Mavi" };
            Console.WriteLine(colorManager.Add(color).Message); 
        }
    }
}
