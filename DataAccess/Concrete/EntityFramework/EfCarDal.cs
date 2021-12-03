using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entitites.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var res = from c in context.Set<Car>()
                          join color in context.Set<Color>()
                          on c.ColorId equals color.Id
                          join bra in context.Set<Brand>()
                          on c.BrandId equals bra.Id
                          select new CarDetailDto
                          {
                              BrandName = bra.Name,
                              ColorName = color.Name,
                              Description = c.Description,
                              DailyPrice = c.DailyPrice
                          };
                return res.ToList();

            } 
        }
    }
}
