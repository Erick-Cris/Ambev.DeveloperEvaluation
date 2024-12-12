﻿using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale;

/// <summary>
/// Request model for getting a sale list
/// </summary>
public class ListSaleRequest
{
    /// <summary>
    /// Gets the sale's  customer id.
    /// Must not be null or empty.
    /// </summary>
    public Guid? CustomerExternalId { get; set; }

    /// <summary>
    /// Gets the sale's  customer name.
    /// Must not be null or empty.
    /// </summary>
    public string? CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets the sale's  customer document.
    /// Must not be null or empty.
    /// </summary>
    public string? CustomerDocument { get; set; } = string.Empty;

    /// <summary>
    /// Gets the sale's  branch id.
    /// Must not be null or empty.
    /// </summary>
    public Guid? BranchExternalId { get; set; }

    /// <summary>
    /// Gets the sale's  branch name.
    /// Must not be null or empty.
    /// </summary>
    public string? BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Gets the sale's price.
    /// Must not be null or empty and could contain sale's total amount.
    /// </summary>
    public decimal? TotalAmount { get; set; } = decimal.Zero;

    /// <summary>
    /// Gets the sale's status.
    /// Must not be null and could contain sale's status.
    /// </summary>
    public SaleStatus? Status { get; set; }

    /// <summary>
    /// Gets the date and time when the sale was created.
    /// </summary>
    public DateTime? CreatedAt { get; set; }
}