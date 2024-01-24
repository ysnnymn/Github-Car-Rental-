﻿using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class RentalValidator:AbstractValidator<Rental>
	{
		public RentalValidator()
		{
			RuleFor(r => r.ReturnDate).NotEmpty();
		}
	}
}

