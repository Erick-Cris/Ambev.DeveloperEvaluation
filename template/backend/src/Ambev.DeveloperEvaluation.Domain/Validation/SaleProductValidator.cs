using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class SaleProductValidator : AbstractValidator<SaleProduct>
    {
        public SaleProductValidator()
        {
            RuleFor(saleSaleProduct => saleSaleProduct.ProductName)
                .NotEmpty()
                .MinimumLength(1).WithMessage("Product name must be at least 3 characters long.");

            RuleFor(saleSaleProduct => saleSaleProduct.ProductDescription)
                .NotEmpty()
                .MinimumLength(3).WithMessage("Product description must be at least 3 characters long.");
        }
    }
}
