using Entitites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(c => c.Number).Must(c => c.ToString().Length == 16);
            RuleFor(c => c.OwnerName).Length(7, 50);
        }
    }
}
