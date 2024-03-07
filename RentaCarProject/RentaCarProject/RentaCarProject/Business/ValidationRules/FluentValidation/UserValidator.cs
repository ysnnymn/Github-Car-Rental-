using System;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class UserValidator:AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(u => u.Email).EmailAddress();
			//RuleFor(u => u.PasswordHash).NotEmpty().MinimumLength(6); // Sonra Bak

		}
	}
}

