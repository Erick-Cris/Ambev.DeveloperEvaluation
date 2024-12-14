using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Customers.GetCustomer;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;

/// <summary>
/// Validator for ListCustomerRequest
/// </summary>
public class ListCustomerRequestValidator : AbstractValidator<ListCustomerRequest>
{
    /// <summary>
    /// Initializes validation rules for ListCustomerRequest
    /// </summary>
    public ListCustomerRequestValidator()
    {
        RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
        RuleFor(customer => customer.Name).NotEmpty().Length(3, 300);
        RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());
        RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
    }
}
