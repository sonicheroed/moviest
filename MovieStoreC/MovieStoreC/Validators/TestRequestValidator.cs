﻿using FluentValidation;
using MovieStoreB.Controllers;

namespace MovieStoreB.Validators
{
    public class TestRequestValidator : AbstractValidator<TestRequest>
    {
        public TestRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Въведи по-голямо от 0");
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(2).MaximumLength(50);
        }
    }
}
