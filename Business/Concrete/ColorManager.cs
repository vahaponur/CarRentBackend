using Business.Abstract;
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

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color Get(int colorId)
        {
            return _colorDal.Get(P => P.Id == colorId);
        }

        public void Update(Color color)
        {
            Color colorToUpdate = Get(color.Id);
            colorToUpdate.Id = color.Id;
            colorToUpdate.Name = color.Name;
            _colorDal.Update(colorToUpdate);
        }
    }
}
