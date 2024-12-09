using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
            RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());

            RuleFor(customer => customer.Name)
                .NotEmpty()
                .MinimumLength(3).WithMessage("Username must be at least 3 characters long.")
                .MaximumLength(300).WithMessage("Username cannot be longer than 300 characters.");


            RuleFor(customer => customer.Phone)
                .Matches(@"^\+[1-9]\d{10,14}$")
                .WithMessage("Phone number must start with '+' followed by 11-15 digits.");

        }
    }
}
