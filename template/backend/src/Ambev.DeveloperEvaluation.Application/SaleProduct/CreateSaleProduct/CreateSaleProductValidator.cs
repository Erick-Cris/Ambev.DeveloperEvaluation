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

            //RuleFor(saleProduct => saleProduct.Quantity).GreaterThan(0).LessThanOrEqualTo(20)
            //    .WithMessage("The quantity of a product type cannot exceed 20 units.");
            RuleFor(saleProduct => saleProduct.Discount).Equal(0).When(saleProduct => saleProduct.Quantity < 4)
                .WithMessage("Purchases below 4 items cannot have a discount.");
            RuleFor(saleProduct => saleProduct.Discount).Equal(0.1m).When(saleProduct => saleProduct.Quantity >= 4 && saleProduct.Quantity < 10)
                .WithMessage("Purchases above 4 identical items have a 10% discount.");
            RuleFor(saleProduct => saleProduct.Discount).Equal(0.2m).When(saleProduct => saleProduct.Quantity >= 10 && saleProduct.Quantity <= 20)
                .WithMessage("Purchases between 10 and 20 identical items have a 20% discount.");
        }
    }
}
