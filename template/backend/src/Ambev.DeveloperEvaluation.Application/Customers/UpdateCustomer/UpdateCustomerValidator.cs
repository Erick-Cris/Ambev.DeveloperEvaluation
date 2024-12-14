using Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer
{
    /// <summary>
    /// Validator for UpdateCustomerCommand that defines validation rules for customer update command.
    /// </summary>
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateCustomerCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Email: Must be in valid format (using EmailValidator)
        /// - Customername: Required, must be between 3 and 50 characters
        /// - Document: Must meet document pattern requirements (using DocumentValidator)
        /// - Phone: Must match international format (+X XXXXXXXXXX)
        /// </remarks>
        public UpdateCustomerCommandValidator()
        {
            RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
            RuleFor(customer => customer.Name).NotEmpty().Length(3, 300);
            RuleFor(customer => customer.Document).SetValidator(new DocumentValidator());
            RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        }
    }
}
