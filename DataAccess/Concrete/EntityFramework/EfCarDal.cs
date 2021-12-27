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
using Core.Utilities.FileSystem;

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
                              CarId = c.Id,
                              Name = c.Name,
                              BrandName = bra.Name,
                              ColorName = color.Name,
                              Description = c.Description,
                              DailyPrice = c.DailyPrice,
                                ModelYear=c.ModelYear

                          };
                
                         

                return res.ToList();

            }
        }
        public CarDetailDto GetCarDetailById(int carId)
        {
            return GetCarDetails().SingleOrDefault(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var res = from c in context.Set<Car>()
                          join color in context.Set<Color>()
                          on c.ColorId equals color.Id
                          join bra in context.Set<Brand>()
                          
                          on c.BrandId equals bra.Id
                          where bra.Id==brandId
                          select new CarDetailDto
                          {
                              CarId = c.Id,
                              Name = c.Name,
                              BrandName = bra.Name,
                              ColorName = color.Name,
                              Description = c.Description,
                              DailyPrice = c.DailyPrice,
                              ModelYear = c.ModelYear

                          };



                return res.ToList();

            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var res = from c in context.Set<Car>()
                          join color in context.Set<Color>()
                          on c.ColorId equals color.Id
                          join bra in context.Set<Brand>()
                          on c.BrandId equals bra.Id
                          where color.Id == colorId
                          select new CarDetailDto
                          {
                              CarId = c.Id,
                              Name = c.Name,
                              BrandName = bra.Name,
                              ColorName = color.Name,
                              Description = c.Description,
                              DailyPrice = c.DailyPrice,
                              ModelYear = c.ModelYear

                          };



                return res.ToList();

            }
        }
    }
}
