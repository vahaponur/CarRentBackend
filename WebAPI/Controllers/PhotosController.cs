using Business.Abstract;
using Core.Utilities.FileSystem;
using Entitites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using File = System.IO.File;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        IPhotoService _photoService;

        public PhotosController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        #region GET
        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var carPhotos=_photoService.GetByCarId(carId);
            if (carPhotos.Data.Count>0)
            {
                return Ok(carPhotos.Data);
            }
            return Ok(FileCRUD.savingPath + "/def.jpg");
            
        }

        #endregion



        #region POST

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromForm] Photo photo, IFormFile file)
        {
            var addResult = FileCRUD.Add(file);
            if (addResult.Success)
            {
                photo.ImagePath = addResult.Message;
                var result = _photoService.Add(photo);
                if (result.Success)
                {
                    return Ok("Photo added");
                }
                return BadRequest(result.Message);

            }

            return BadRequest(addResult.Message);
        }


        [HttpPost("update")]
        public async Task<IActionResult> Update([FromForm] Photo photo, IFormFile file)
        {
            string path = FileCRUD.Update(photo.ImagePath, file).Message;
            photo.ImagePath = path;
            var result = _photoService.Update(photo);
            if (result.Success)
            {
                return Ok("Photo updated");
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromForm] Photo photo)
        {
            var delResult = FileCRUD.Delete(photo.ImagePath);
            if (delResult.Success)
            {
                var result = _photoService.Delete(photo);
                if (result.Success)
                {
                    return Ok("Photo deleted");
                }
                return BadRequest(result.Message);

            }
            return BadRequest(delResult.Message);

        }

        #endregion

    }
}
