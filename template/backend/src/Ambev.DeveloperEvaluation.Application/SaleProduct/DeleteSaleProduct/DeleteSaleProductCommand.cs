using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.DeleteSaleProduct
{
    /// <summary>
    /// Command for deleting a saleProduct
    /// </summary>
    public record DeleteSaleProductCommand : IRequest<DeleteSaleProductResponse>
    {
        /// <summary>
        /// The unique identifier of the saleProduct to delete
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of DeleteSaleProductCommand
        /// </summary>
        /// <param name="id">The ID of the saleProduct to delete</param>
        public DeleteSaleProductCommand(Guid id)
        {
            Id = id;
        }
    }

}
