using Ambev.DeveloperEvaluation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    /// <summary>
    /// Response model for GetSale operation
    /// </summary>
    public class GetSaleResult
    {
        /// <summary>
        /// The unique identifier of the sale
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets the sale's  customer id.
        /// Must not be null or empty.
        /// </summary>
        public Guid CustomerExternalId { get; set; }

        /// <summary>
        /// Gets the sale's  customer name.
        /// Must not be null or empty.
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's  customer document.
        /// Must not be null or empty.
        /// </summary>
        public string CustomerDocument { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's  branch id.
        /// Must not be null or empty.
        /// </summary>
        public Guid BranchExternalId { get; set; }

        /// <summary>
        /// Gets the sale's  branch name.
        /// Must not be null or empty.
        /// </summary>
        public string BranchName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's price.
        /// Must not be null or empty and could contain sale's total amount.
        /// </summary>
        public decimal TotalAmount { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the sale's status.
        /// Must not be null and could contain sale's status.
        /// </summary>
        public SaleStatus Status { get; set; }

        /// <summary>
        /// Gets the date and time when the sale was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time of the last update to the sale's information.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}