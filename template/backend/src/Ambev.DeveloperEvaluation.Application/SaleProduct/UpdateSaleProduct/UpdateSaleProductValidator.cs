using Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct
{
    /// <summary>
    /// Validator for UpdateSaleProductCommand that defines validation rules for saleProduct update command.
    /// </summary>
    public class UpdateSaleProductCommandValidator : AbstractValidator<UpdateSaleProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSaleProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - ProductName: Required, must be 1 or more characters
        /// - ProductDescription: Required, must be 3 or more characters
        /// </remarks>
        public UpdateSaleProductCommandValidator()
        {
            RuleFor(saleProduct => saleProduct.ProductName).NotEmpty().MinimumLength(1);
            RuleFor(saleProduct => saleProduct.ProductDescription).NotEmpty().MinimumLength(3);
        }
    }
}
