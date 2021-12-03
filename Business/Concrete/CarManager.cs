using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2) 
                throw new Exception("Açıklama 2 harften büyük olmalıdır");
                 
            if (car.DailyPrice <= 0)
                throw new Exception("Arabanın günlük fiyatı 0 dan büyük olmalıdır");

            _carDal.Add(car);



        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car Get(int carId)
        {
            return _carDal.Get(p => p.Id == carId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = Get(car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            _carDal.Update(carToUpdate);
        }
    }
}
