using Core.DataAccess;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        Rental GetLastByCarId(int carId);
        List<Rental> GetAllByCarId(int carId);
        List<Rental> GetFutureRentalsByCarId(int carId);
    }
}
