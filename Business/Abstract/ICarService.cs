using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
 
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
    }
}
