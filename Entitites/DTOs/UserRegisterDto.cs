using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class UserRegisterDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
    }
}
