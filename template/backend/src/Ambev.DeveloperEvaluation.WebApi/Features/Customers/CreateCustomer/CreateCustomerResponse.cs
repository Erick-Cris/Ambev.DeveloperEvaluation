﻿using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;

/// <summary>
/// API response model for CreateCustomer operation
/// </summary>
public class CreateCustomerResponse
{
    /// <summary>
    /// The unique identifier of the created customer
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The customer's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The customer's document
    /// </summary>
    public string Document { get; set; } = string.Empty;


    /// <summary>
    /// The customer's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The customer's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;

}
