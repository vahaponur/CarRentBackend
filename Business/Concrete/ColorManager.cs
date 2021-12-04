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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.SuccessfullyAdded);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> Get(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(P => P.Id == colorId));
           
        }

        public IResult Update(Color color)
        {
            Color colorToUpdate = _colorDal.Get(c => c.Id == color.Id);
            colorToUpdate.Id = color.Id;
            colorToUpdate.Name = color.Name;
            _colorDal.Update(colorToUpdate);
            return new SuccessResult();
        }
    }
}
