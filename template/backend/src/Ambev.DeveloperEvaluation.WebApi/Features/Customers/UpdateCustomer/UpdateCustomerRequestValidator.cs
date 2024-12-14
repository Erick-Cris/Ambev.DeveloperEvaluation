using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.UpdateCustomer;

/// <summary>
/// Validator for UpdateCustomerRequest that defines validation rules for customer creation.
/// </summary>
public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateCustomerRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// </remarks>
    public UpdateCustomerRequestValidator()
    {
        RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
        RuleFor(customer => customer.Name).NotEmpty().Length(3, 300);
        RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());
        RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
    }
}