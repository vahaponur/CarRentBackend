using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental entity)
        {
            var rules =BusinessRules.Run(SetRentalDate(entity));
            if (!rules.Success)
            {
                return rules;

            }
            _rentalDal.Add(entity);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.SuccessfullyDeleted);
        }

        public IDataResult<Rental> Get(int entityId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == entityId));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        [Obsolete("Deprecated.")]
        public IResult SetRentDate(Rental entity)
        {
           
            string sqlFormattedDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime.TryParse(sqlFormattedDate,out DateTime datenow);
            entity.RentDate = datenow;
            return new SuccessResult();
        } 
        public IResult SetRentalDate(Rental entity)
        {
            if (entity.RentDate ==null)
            {
                entity.RentDate = DateTime.UtcNow;

            }
            return new SuccessResult();
        }

        public IDataResult<Rental> GetLastByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetLastByCarId(carId));
        }
    }
}
