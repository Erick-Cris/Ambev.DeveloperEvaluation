using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleCommand that defines validation rules for sale creation command.
    /// </summary>
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be 1 or more characters
        /// - Description: Required, must be 3 or more characters
        /// </remarks>
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.CustomerName)
                .NotEmpty()
                .MinimumLength(3).WithMessage("CustomerName must be at least 3 characters long.")
                .MaximumLength(300).WithMessage("CustomerName cannot be longer than 300 characters.");

            RuleFor(sale => sale.CustomerDocument).SetValidator(new DocumentValidator());

            RuleFor(sale => sale.BranchName)
                .NotEmpty()
                .MinimumLength(1).WithMessage("BranchName must be at least 3 characters long.");
        }
    }
}
