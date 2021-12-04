using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand entity)
        {

            _brandDal.Add(entity);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.SuccessfullyDeleted);
        }

        public IDataResult<Brand> Get(int entityId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id==entityId));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Update(Brand entity)
        {
            Brand brandToUpdate = _brandDal.Get(b=>b.Id==entity.Id);
            brandToUpdate.Id = entity.Id;
            brandToUpdate.Name = entity.Name;
            return new SuccessResult(Messages.SuccessfullyUpdated);
        }
    }
}
