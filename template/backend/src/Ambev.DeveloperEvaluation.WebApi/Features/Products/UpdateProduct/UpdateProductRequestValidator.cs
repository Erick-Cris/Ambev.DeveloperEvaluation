using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductRequest that defines validation rules for product creation.
/// </summary>
public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, length between 1 or more characters
    /// - Description: Required, length between 3 or more characters
    /// </remarks>
    public UpdateProductRequestValidator()
    {
        RuleFor(product => product.Name).NotEmpty().MinimumLength(1);
        RuleFor(product => product.Description).NotEmpty().MinimumLength(3);
    }
}