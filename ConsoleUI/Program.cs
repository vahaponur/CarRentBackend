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
            UserManager userManager = new UserManager(new EfUserDal());
            User user1 = new User { Email = "vaap@deneme.com", FirstName = "Vahap Onur", LastName = "YILDIRIM", Password = "123456" };
            var result = userManager.Add(user1);
            Console.WriteLine(result.Message);
        }
    }
}
