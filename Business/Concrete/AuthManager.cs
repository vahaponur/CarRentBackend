using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Token;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            return new SuccessDataResult<AccessToken>(_tokenHelper.CreateToken(user,_userService.GetOperationClaims(user).Data),Messages.AccessTokenCreated);
        }

        public IDataResult<User> Login(UserLoginDto userLoginDto)
        {
            var userToCheck = _userService.GetByEmail(userLoginDto.Email).Data;
            if (userToCheck == null)
            {
                return new FailDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new FailDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck);
        }

        public IDataResult<User> Register(UserRegisterDto userRegisterDto)
        {
            var result = BusinessRules.Run(UserNotExist(userRegisterDto.Email));
            if (!result.Success)
            {
                return new FailDataResult<User>(result.Message);
            }
            HashingHelper.CreatePasswordHash(userRegisterDto.Password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = new User
            {
                Email = userRegisterDto.Email,
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status=true
            };

            _userService.Add(user);
            return new SuccessDataResult<User>(user,Messages.UserRegistered);
        }

        public IResult UserNotExist(string email)
        {
            
            if (_userService.GetByEmail(email).Data != null)
            {
                return new FailResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
