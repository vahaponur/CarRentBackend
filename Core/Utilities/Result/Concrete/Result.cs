using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }
        public Result(bool success,string message) : this(success)
        {
            Message = message;
        }
        public string Message { get; }

        public bool Success { get; }
    }
}
