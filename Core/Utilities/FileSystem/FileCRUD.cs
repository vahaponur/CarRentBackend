using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Core.Utilities.FileSystem
{
    public class FileCRUD
    {
        public const long maxFileSize = 10485760;
        static string path = @"C:\Users\vaap\source\repos\CarRentFrontend\src\assets\car_images";
        
        public static string savingPath = path;
        
        public static IResult Add(IFormFile file, string path = "")
        {
            if (path == "") path = savingPath;
            var result = BusinessRules.Run(FileSizeIsOk(maxFileSize,file));

            if (result.Success)
            {
                string pathToSave = path + @"\" + ToGuid() + System.IO.Path.GetExtension(file.FileName);

                using (FileStream fileStream = System.IO.File.Create(pathToSave))
                {
                    file.CopyTo(fileStream);

                    fileStream.Flush();
                }
                return new SuccessResult(pathToSave);
            }

            return result;
        }

        public static IResult Update(string path,IFormFile file)
        {
            var result = BusinessRules.Run(FileSizeIsOk(maxFileSize, file));
            if (result.Success)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return Add(file);
                }
                else return new FailResult("Path couldn't found.");
            }
            else return result;

        }

        public static IResult Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                return new SuccessResult("Successfully deleted");
            }
            return new FailResult("Path couldn't found");
        }
        public static string ToGuid()
        {
            return Guid.NewGuid().ToString();
        }
        private static IResult FileSizeIsOk(long fileSize, IFormFile file)
        {
            if (file.Length < fileSize)
            {
                return new SuccessResult();
            }
            return new FailResult("File size is too big. Max size = "+fileSize);
        }


    }
}
