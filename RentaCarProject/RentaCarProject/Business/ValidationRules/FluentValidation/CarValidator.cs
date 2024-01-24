﻿using System;
using System.Runtime.ConstrainedExecution;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {

            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
