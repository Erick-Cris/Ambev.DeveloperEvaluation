using Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.ListCustomer
{
    /// <summary>
    /// Command for retrieving a customer's list
    /// </summary>
    public record ListCustomerCommand : IRequest<List<ListCustomerResult>>
    {

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


        /// <summary>
        /// Initializes a new instance of ListCustomerCommand
        /// </summary>
        /// <param name="name">The name of the customer to retrieve</param>
        /// <param name="description">The description of the customer to retrieve</param>
        /// <param name="price">The price of the customer to retrieve</param>
        public ListCustomerCommand(string name, string document, string phone, string email)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Email = email;
        }
    }

}
