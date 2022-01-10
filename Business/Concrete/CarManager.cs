using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  Core.Aspects.Autofac.Caching;
using Entitites.DTOs;
using Core.TimeHelper;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IRentalService _rentalService;
        public CarManager(ICarDal carDal,IRentalService rentalService)
        {
            _carDal = carDal;
            _rentalService = rentalService;
        }
        
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }
        
        [SecuredOperation("car.delete,admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessfullyDeleted);
        }
        
        [CacheAspect()]
        public IDataResult<Car> Get(int entityId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == entityId));
        }
        
        
        [CacheAspect()]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }
        
        [CacheAspect()]
        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId).ToList());
        }
        
        [CacheAspect()]
        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId).ToList());
        }

        public IDataResult<List<Car>> GetAvaliableCarsByDateInterval(DateTime rentTime, DateTime returnTime)
        {

            var result = GetAll();
            var avaliableCars = new List<Car>(result.Data);
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    var rents = _rentalService.GetFutureRentalsByCarId(item.Id);
                    foreach (var rent in rents.Data)
                    {
                        if (TimeHelper.TimeIntersect(rentTime, returnTime, rent.RentDate.GetValueOrDefault(),rent.ReturnDate.GetValueOrDefault()))
                        {
                            avaliableCars.Remove(item);
                        }
                    }
                   
                }
            }

            return new SuccessDataResult<List<Car>>(avaliableCars);
        }
    
        [CacheAspect()]
        public IDataResult<CarDetailDto> GetCarDetailById(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetailById(carId));
        }
        [CacheAspect()]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [CacheAspect()]
        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByBrandId(brandId));
        }
        [CacheAspect()]
        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByColorId(colorId));
        }

        [SecuredOperation("car.update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.SuccessfullyUpdated);
        }
    }
}
