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

        
        [HttpPost("add")]
       public async Task<IActionResult> Add([FromForm]string carId,IFormFile file)
        {
            string path = FileCRUD.savingPath;
            Photo photo = new Photo();
            photo.CarId = int.Parse(carId);

            string pathToSave = path + @"/" + Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);

            photo.ImagePath = pathToSave;
            using (FileStream fileStream = System.IO.File.Create(pathToSave))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }
            _photoService.Add(photo);
            return Ok();
        }
    }
}
