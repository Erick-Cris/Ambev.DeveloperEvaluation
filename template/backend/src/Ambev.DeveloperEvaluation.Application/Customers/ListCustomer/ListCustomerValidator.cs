using Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.ListCustomer
{
    /// <summary>
    /// Validator for ListCustomerCommand
    /// </summary>
    public class ListCustomerValidator : AbstractValidator<ListCustomerCommand>
    {
        /// <summary>
        /// Initializes validation rules for ListCustomerCommand
        /// </summary>
        public ListCustomerValidator()
        {
            //RuleFor(x => x.Name)
            //.NotEmpty()
            //.WithMessage("Customer Name is required");
        }
    }
}
