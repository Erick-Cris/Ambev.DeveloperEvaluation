using Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;


namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer
{
    /// <summary>
    /// Command for updating a customer.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for updating a customer, 
    /// including name, email, phone number and document. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateCustomerResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateCustomerValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>

    public class UpdateCustomerCommand : IRequest<UpdateCustomerResult>
    {
        /// <summary>
        /// Gets or sets the GUID of the unique identificator of customer to be updated.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets the customer's full name.
        /// Must not be null or empty and should contain both first and last names.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets the customer's document.
        /// Must not be null or empty and could contain CPF or CNPJ.
        /// </summary>
        public string Document { get; set; } = string.Empty;

        /// <summary>
        /// Gets the customer's phone.
        /// Must not be null or empty and could contain Phone or Cellphone.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets the customer's e-mail.
        /// Must not be null or empty and could contain e-mail.
        /// </summary>
        public string Email { get; set; } = string.Empty;



        public ValidationResultDetail Validate()
        {
            var validator = new UpdateCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}

