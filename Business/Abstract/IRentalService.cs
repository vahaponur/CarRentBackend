using Core.Utilities.Result.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService:ICrudBase<Rental>
    {
        IDataResult<Rental> GetLastByCarId(int carId);
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<Rental>> GetFutureRentalsByCarId(int carId);
    }
}
