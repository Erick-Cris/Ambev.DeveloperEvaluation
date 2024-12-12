using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleRequest that defines validation rules for sale creation.
/// </summary>
public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - CustomerName: Required, length between 3 and 300 characters
    /// - CustomerDocument: Required, valid pattern
    /// - BranchName: Required, length between 3 or more
    /// </remarks>
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.CustomerName)
        .NotEmpty()
        .MinimumLength(3).WithMessage("CustomerName must be at least 3 characters long.")
        .MaximumLength(300).WithMessage("CustomerName cannot be longer than 300 characters.");

        RuleFor(sale => sale.CustomerDocument).SetValidator(new DocumentValidator());

        RuleFor(sale => sale.BranchName)
            .NotEmpty()
            .MinimumLength(3).WithMessage("BranchName must be at least 3 characters long.");
    }
}