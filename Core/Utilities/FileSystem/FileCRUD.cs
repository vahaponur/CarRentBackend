using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Core.Utilities.FileSystem
{
    public class FileCRUD
    {
        static string path = Directory.GetParent(Directory.GetCurrentDirectory().ToString()).FullName;

        public static string savingPath = path + @"/DataAccess/ExternalFiles";

        public static string ToGuid()
        {
            return Guid.NewGuid().ToString();
        }
            
            
    }
}
