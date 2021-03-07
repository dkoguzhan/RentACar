using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buisness.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(3);
            //RuleFor(c => c.).NotEmpty();
            //RuleFor(c => c.).GreaterThan(0);
            //RuleFor(c => c.).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

        }
    }
}
