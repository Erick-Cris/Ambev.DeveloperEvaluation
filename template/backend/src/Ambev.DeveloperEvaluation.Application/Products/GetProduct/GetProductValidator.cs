using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    /// <summary>
    /// Validator for GetProductCommand
    /// </summary>
    public class GetProductValidator : AbstractValidator<GetProductCommand>
    {
        /// <summary>
        /// Initializes validation rules for GetProductCommand
        /// </summary>
        public GetProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Product ID is required");
        }
    }
}
