using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        #region GET
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.Get(id);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyemail")]
        public IActionResult GetByEmail(string email)
        {
            var result = _userService.GetByEmail(email);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        #endregion



        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result );
        }

        [HttpPatch("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
