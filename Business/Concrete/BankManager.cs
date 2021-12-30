using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BankManager : IBankService
    {
        [ValidationAspect(typeof(CreditCardValidator))]
        public IResult Payment(CreditCard creditCard)
        {
            return new SuccessResult("Ödeme başarıyla alındı.");
        }
    }
}
