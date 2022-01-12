﻿using FluentValidation;
using GoodNoodle.Domain.Commands;
using GoodNoodle.Domain.Errors;
using GoodNoodle.Domain.Extensions.Validations;

namespace GoodNoodle.Domain.Validations.NoodleUser;

public class ValidateCreateNoodleUser : AbstractValidator<CreateNoodleUserCommand>
{
    public ValidateCreateNoodleUser()
    {
        AddRuleForId();
        AddRuleForEmail();
        AddRuleForFullName();
        AddRuleForPassword();
    }

    private void AddRuleForId()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithErrorCode(DomainErrorCodes.UserEmptyId);
    }

    private void AddRuleForEmail()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithErrorCode(DomainErrorCodes.UserEmptyEmail)
            .EmailAddress()
            .WithErrorCode(DomainErrorCodes.UserInvalidEmail);
    }

    private void AddRuleForPassword()
    {
        RuleFor(x => x.Password).Password();
    }

    private void AddRuleForFullName()
    {
        RuleFor(x => x.FullName)
            .NotEmpty()
            .WithErrorCode(DomainErrorCodes.UserEmptyFullName)
            .MaximumLength(100)
            .WithErrorCode(DomainErrorCodes.UserLongFullName);
    }
}
