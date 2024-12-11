using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// Validator for ListProductRequest
/// </summary>
public class ListProductRequestValidator : AbstractValidator<ListProductRequest>
{
    /// <summary>
    /// Initializes validation rules for ListProductRequest
    /// </summary>
    public ListProductRequestValidator()
    {
        //RuleFor(x => x.Name)
        //    .NotEmpty()
        //    .WithMessage("Product Name is required");
    }
}
