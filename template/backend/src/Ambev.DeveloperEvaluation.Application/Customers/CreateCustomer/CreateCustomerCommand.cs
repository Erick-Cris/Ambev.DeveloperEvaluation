using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer
{
    /// <summary>
    /// Command for creating a new customer.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for creating a customer, 
    /// including name, email, phone number and document. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateCustomerResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateCustomerCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>
    
    public class CreateCustomerCommand : IRequest<CreateCustomerResult>
    {
        /// <summary>
        /// Gets or sets the name of the customer to be created.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the document for the customer.
        /// </summary>
        public string Document { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number for the customer.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email address for the customer.
        /// </summary>
        public string Email { get; set; } = string.Empty;


        public ValidationResultDetail Validate()
        {
            var validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
