using Ambev.DeveloperEvaluation.Application.SaleProducts.DeleteSaleProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.DeleteSaleProduct
{
    /// <summary>
    /// Validator for DeleteSaleProductCommand
    /// </summary>
    public class DeleteSaleProductValidator : AbstractValidator<DeleteSaleProductCommand>
    {
        /// <summary>
        /// Initializes validation rules for DeleteSaleProductCommand
        /// </summary>
        public DeleteSaleProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("SaleProduct ID is required");
        }
    }
}
