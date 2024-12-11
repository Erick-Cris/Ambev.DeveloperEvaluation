using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest that defines validation rules for product creation.
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, length between 1 or more characters
    /// - Description: Required, length between 3 or more characters
    /// </remarks>
    public CreateProductRequestValidator()
    {
        RuleFor(product => product.Name).NotEmpty().MinimumLength(1);
        RuleFor(product => product.Description).NotEmpty().MinimumLength(3);
    }
}