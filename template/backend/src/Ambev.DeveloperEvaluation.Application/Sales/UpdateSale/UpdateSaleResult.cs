using Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale
{
    /// <summary>
    /// Represents the response returned after successfully updating a sale.
    /// </summary>
    /// <remarks>
    /// This response contains the data of the updated sale,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateSaleResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the updated sale.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated sale in the system.</value>
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

        public List<UpdateSaleProductDto> SaleProducts { get; set; }
    }
}
