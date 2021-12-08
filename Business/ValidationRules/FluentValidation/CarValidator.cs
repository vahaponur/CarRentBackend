using System;
using System.Collections.Generic;
using System.Text;
using Entitites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(10);
            RuleFor(c => c.Description).NotEmpty();

            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();

        }
    }
}
