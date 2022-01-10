using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public Rental GetLastByCarId(int carId)
        {
            return GetAll(r => r.CarId == carId).OrderByDescending(r => r.Id).FirstOrDefault();
        }
        public List<Rental> GetAllByCarId(int carId)
        {
            return GetAll(r => r.CarId == carId).ToList();
        }
        public List<Rental> GetFutureRentalsByCarId(int carId)
        {
            return GetAll(r => r.CarId == carId).Where(r => r.ReturnDate.GetValueOrDefault().Date > DateTime.Today).ToList();
        }
    }
}
