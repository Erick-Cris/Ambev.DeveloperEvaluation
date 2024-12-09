using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;

/// <summary>
/// Validator for CreateCustomerRequest that defines validation rules for customer creation.
/// </summary>
public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateCustomerRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be valid format (using EmailValidator)
    /// - Name: Required, length between 3 and 300 characters
    /// - Document: Must meet pattern requirements (using DocumentValidator)
    /// - Phone: Must match international format (+X XXXXXXXXXX)
    /// </remarks>
    public CreateCustomerRequestValidator()
    {
        RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
        RuleFor(customer => customer.Name).NotEmpty().Length(3, 300);
        RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());
        RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
    }
}