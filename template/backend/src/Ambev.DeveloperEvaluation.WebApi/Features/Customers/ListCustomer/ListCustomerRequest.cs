﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;

/// <summary>
/// Request model for getting a customer list
/// </summary>
public class ListCustomerRequest
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
}
