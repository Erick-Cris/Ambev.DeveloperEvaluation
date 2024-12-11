using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// Validator for UpdateProductCommand that defines validation rules for product update command.
    /// </summary>
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be 1 or more characters
        /// - Description: Required, must be 3 or more characters
        /// </remarks>
        public UpdateProductCommandValidator()
        {
            RuleFor(product => product.Name).NotEmpty().MinimumLength(1);
            RuleFor(product => product.Description).NotEmpty().MinimumLength(3);
        }
    }
}
