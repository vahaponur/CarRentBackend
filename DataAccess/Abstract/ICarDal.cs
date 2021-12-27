using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        CarDetailDto GetCarDetailById(int carId);
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);
        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
    }
}
