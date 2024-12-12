using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale;

/// <summary>
/// Validator for ListSaleRequest
/// </summary>
public class ListSaleRequestValidator : AbstractValidator<ListSaleRequest>
{
    /// <summary>
    /// Initializes validation rules for ListSaleRequest
    /// </summary>
    public ListSaleRequestValidator()
    {
        //RuleFor(x => x.Name)
        //    .NotEmpty()
        //    .WithMessage("Sale Name is required");
    }
}
