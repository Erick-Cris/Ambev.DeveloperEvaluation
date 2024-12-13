using Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct
{
    /// <summary>
    /// Validator for CreateSaleProductCommand that defines validation rules for saleProduct creation command.
    /// </summary>
    public class CreateSaleProductCommandValidator : AbstractValidator<CreateSaleProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be 1 or more characters
        /// - Description: Required, must be 3 or more characters
        /// </remarks>
        public CreateSaleProductCommandValidator()
        {
            RuleFor(saleProduct => saleProduct.ProductName).NotEmpty().MinimumLength(1);
            RuleFor(saleProduct => saleProduct.ProductDescription).NotEmpty().MinimumLength(3);
        }
    }
}
