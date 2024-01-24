using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class UserValidator:AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(u => u.Email).EmailAddress();
			RuleFor(u => u.Password).NotEmpty().MinimumLength(6);
		}
	}
}

