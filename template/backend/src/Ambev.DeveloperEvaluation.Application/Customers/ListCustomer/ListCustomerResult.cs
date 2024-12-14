using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.ListCustomer
{
    /// <summary>
    /// Response model for ListCustomer operation
    /// </summary>
    public class ListCustomerResult
    {
        /// <summary>
        /// The unique identifier of the customer
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
    }
}