using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Abstract
{
    public interface IUserService : ICrudBase<User>
    {
        IDataResult<List<OperationClaim>> GetOperationClaims(User entity);
        IDataResult<User> GetByEmail(string email);
    }
}
