﻿using FluentValidation;

namespace Service.Mediator.V1.AccountCase.Login.Validation
{
    public class LoginUserValidator : AbstractValidator<LoginUserQuery>
    {
        public LoginUserValidator()
        {
            RuleFor(e => e.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(e => e.Password)
                .NotEmpty()
                .MinimumLength(6);
        }
    }
}
