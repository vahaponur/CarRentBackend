using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPhotoDal:EfEntityRepositoryBase<Photo,CarRentContext>,IPhotoDal
    {
    }
}
