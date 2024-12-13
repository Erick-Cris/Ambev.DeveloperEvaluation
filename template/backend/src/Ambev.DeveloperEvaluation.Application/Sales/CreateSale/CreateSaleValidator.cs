using Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct;
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

            //RuleForEach(sale => sale.SaleProducts).SetValidator(new CreateSaleProductCommandValidator());

            RuleFor(sale => sale.SaleProducts)
                .Must(HaveUniqueProductExternalIds).WithMessage("Each SaleProduct must have a unique ProductExternalId.")
                .Must(NotExceedMaxQuantity).WithMessage("The quantity of a product type cannot exceed 20 units.");
        }

        private bool HaveUniqueProductExternalIds(List<CreateSaleProductDto> saleProducts)
        {
            var productExternalIds = saleProducts.Select(sp => sp.ProductExternalId).ToList();
            return productExternalIds.Distinct().Count() == productExternalIds.Count();
        }

        private bool NotExceedMaxQuantity(List<CreateSaleProductDto> saleProducts)
        {
            return saleProducts.All(sp => sp.Quantity <= 20);
        }
    }
}
