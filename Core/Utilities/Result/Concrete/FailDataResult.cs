using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class FailDataResult<T> : DataResult<T>
    {
        public FailDataResult(T data, string message) : base(data, false, message) { }
        public FailDataResult(T data) : base(data, false) { }
        public FailDataResult(string message) : base(default, false, message) { }
        public FailDataResult() : base(default, false) { }

    }
}
