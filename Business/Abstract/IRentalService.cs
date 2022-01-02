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
    }
}
