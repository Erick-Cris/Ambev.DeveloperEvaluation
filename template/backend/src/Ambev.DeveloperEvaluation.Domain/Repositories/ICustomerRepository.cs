﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Customer entity operations
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Creates a new customer in the repository
        /// </summary>
        /// <param name="customer">The customer to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created customer</returns>
        Task<Customer> CreateAsync(Customer customer, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a customer by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the customer</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The customer if found, null otherwise</returns>
        Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a customer by their email address
        /// </summary>
        /// <param name="email">The email address to search for</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The customer if found, null otherwise</returns>
        Task<Customer?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of customers based on the provided filters
        /// </summary>
        /// <param name="name">The name of the customer</param>
        /// <param name="document">The document of the customer</param>
        /// <param name="phone">The phone of the customer</param>
        /// <param name="email">The email of the customer</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of customers that match the filters</returns>
        Task<List<Customer>> ListAsync(string name, string document, string phone, string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing customer in the repository
        /// </summary>
        /// <param name="customer">The customer to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated customer</returns>
        Task<Customer> UpdateAsync(Customer customer, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a customer from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the customer to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the customer was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
