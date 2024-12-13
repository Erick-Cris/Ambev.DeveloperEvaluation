using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSale
{
    /// <summary>
    /// Command for retrieving a sale's list
    /// </summary>
    public record ListSaleCommand : IRequest<List<ListSaleResult>>
    {
        /// <summary>
        /// Gets the sale's   id.
        /// Must not be null or empty.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets the sale's  customer id.
        /// Must not be null or empty.
        /// </summary>
        public Guid? CustomerExternalId { get; set; }

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
        public Guid? BranchExternalId { get; set; }

        /// <summary>
        /// Gets the sale's  branch name.
        /// Must not be null or empty.
        /// </summary>
        public string BranchName { get; set; } = string.Empty;

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


        /// <summary>
        /// Initializes a new instance of ListSaleCommand
        /// </summary>
        /// <param name="customerExternalId">The customer's id of the sale to retrieve</param>
        /// <param name="customerName">The customer's name of the sale to retrieve</param>
        /// <param name="customerDocument">The customer's document of the sale to retrieve</param>
        /// <param name="branchExternalId">The branch's id of the sale to retrieve</param>
        /// <param name="branchName">The branch's name of the sale to retrieve</param>
        /// <param name="status">The status of the sale to retrieve</param>
        /// <param name="totalAmount">The total amount of the sale to retrieve</param>
        /// <param name="createdAt">The creation date and time of the sale to retrieve</param>
        public ListSaleCommand(
            Guid? customerExternalId, 
            string customerName, 
            string customerDocument,
            Guid? branchExternalId,
            string branchName,
            SaleStatus? status,
            decimal? totalAmount,
            DateTime? createdAt
            )
        {
            CustomerExternalId = customerExternalId;
            CustomerName = customerName;
            CustomerDocument = customerDocument;
            BranchExternalId = branchExternalId;
            BranchName = branchName;
            Status = status;
            TotalAmount = totalAmount;
            CreatedAt = createdAt;
        }
    }

}
