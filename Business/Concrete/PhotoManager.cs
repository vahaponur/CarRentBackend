using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PhotoManager : IPhotoService
    {
        IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public IResult Add(Photo entity)
        {
            IResult applicaple = BusinessRules.Run(MaxPictureSizeOk(entity.CarId,5));

            if (!applicaple.Success)
            {
                return applicaple;  
            }
            entity.Date = DateTime.UtcNow;
            _photoDal.Add(entity);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        public IResult AddWhole(List<Photo> photos)
        {
            foreach(Photo photo in photos)
            {
                IResult applicaple = BusinessRules.Run(ToGuid(photo));
                if (!applicaple.Success)
                {
                    return applicaple;
                }
                _photoDal.Add(photo);
            }

            return new SuccessResult(Messages.SuccessfullyAdded);

        }

        public IResult Delete(Photo entity)
        {
            IResult applicaple = BusinessRules.Run();

            if (!applicaple.Success)
            {
                return applicaple;
            }

            _photoDal.Delete(entity);
            return new SuccessResult(Messages.SuccessfullyDeleted);
        }

        public IDataResult<Photo> Get(int entityId)
        {
            return new SuccessDataResult<Photo>(_photoDal.Get(p => p.Id == entityId));

        }

        public IDataResult<List<Photo>> GetAll()
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll());

        }

        public IDataResult<List<Photo>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll(p => p.CarId == carId));
        }

        public IResult Update(Photo entity)
        {
            IResult applicaple = BusinessRules.Run();

            if (!applicaple.Success)
            {
                return applicaple;
            }

            _photoDal.Update(entity);
            return new SuccessResult(Messages.SuccessfullyUpdated);
        }

        private IResult ToGuid(Photo entity)
        {
            entity.ImagePath = new Guid().ToString();
            return new SuccessResult();
        }
        private IResult MaxPictureSizeOk(int carId,int size)
        {
            int carPhotos = GetByCarId(carId).Data.Count;
            if (size>carPhotos)
            {
                return new SuccessResult();
            }
            return new FailResult("This car already has "+size+" photos.");
        }


    }
}
