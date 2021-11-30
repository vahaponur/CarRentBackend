using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1,ColorId=1, ModelYear=2005, DailyPrice=280000, Description="BMW M5"},
                new Car{CarId=2, BrandId=1,ColorId=2, ModelYear=2015, DailyPrice=1000000, Description="BMW 525xD"},
                new Car{CarId=3, BrandId=2,ColorId=5, ModelYear=2009, DailyPrice=420000, Description="Mitsubishi Evo "},
                new Car{CarId=4, BrandId=2,ColorId=1, ModelYear=2011, DailyPrice=580000, Description="Mitsubishi Evo"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.CarId == car.CarId);
            
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
