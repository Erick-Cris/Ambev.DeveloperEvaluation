using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer
{
    /// <summary>
    /// Validator for GetCustomerCommand
    /// </summary>
    public class GetCustomerValidator : AbstractValidator<GetCustomerCommand>
    {
        /// <summary>
        /// Initializes validation rules for GetCustomerCommand
        /// </summary>
        public GetCustomerValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Customer ID is required");
        }
    }
}
