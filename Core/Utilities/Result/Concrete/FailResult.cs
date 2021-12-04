using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class FailResult : Result
    {
        public FailResult() : base(false) { }
        public FailResult(string message) : base(false, message) { }

    }
}
