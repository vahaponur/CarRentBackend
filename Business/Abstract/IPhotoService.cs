using Core.Utilities.Result.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPhotoService:ICrudBase<Photo>
    {
      IResult AddWhole(List<Photo> photos);
      IDataResult<List<Photo>> GetByCarId(int carId);
    }
}
