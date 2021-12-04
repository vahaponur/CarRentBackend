using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2) 
                throw new Exception("Açıklama 2 harften büyük olmalıdır");
                 
            if (car.DailyPrice <= 0)
                throw new Exception("Arabanın günlük fiyatı 0 dan büyük olmalıdır");

            _carDal.Add(car);

            return new SuccessResult(Messages.SuccessfullyAdded);


        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessfullyDeleted);
        }

        public IDataResult<Car> Get(int entityId)
        {

            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == entityId));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId).ToList());
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId).ToList());
        }

        public IResult Update(Car car)
        {
            Car carToUpdate = _carDal.Get(p=>p.Id==car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            _carDal.Update(carToUpdate);
            return new SuccessResult(Messages.SuccessfullyUpdated);
        }
    }
}
