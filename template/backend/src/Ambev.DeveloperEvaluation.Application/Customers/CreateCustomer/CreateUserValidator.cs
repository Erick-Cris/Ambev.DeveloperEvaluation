using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer
{
    /// <summary>
    /// Validator for CreateCustomerCommand that defines validation rules for customer creation command.
    /// </summary>
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateCustomerCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Email: Must be in valid format (using EmailValidator)
        /// - Customername: Required, must be between 3 and 50 characters
        /// - Document: Must meet document pattern requirements (using DocumentValidator)
        /// - Phone: Must match international format (+X XXXXXXXXXX)
        /// </remarks>
        public CreateCustomerCommandValidator()
        {
            RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
            RuleFor(customer => customer.Name).NotEmpty().Length(3, 300);
            RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());
            RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        }
    }
}
