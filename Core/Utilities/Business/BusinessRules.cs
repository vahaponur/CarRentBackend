using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] rules)
        {
            foreach (var rule in rules)
            {
                if (!rule.Success)
                    return rule;
            }
            return new SuccessResult();
        }

       
    }
}
