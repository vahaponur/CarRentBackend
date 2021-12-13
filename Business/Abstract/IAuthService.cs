using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Security.Token;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserRegisterDto userRegisterDto );
        IDataResult<User> Login(UserLoginDto userLoginDto);
        IResult UserNotExist(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
