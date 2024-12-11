using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    /// <summary>
    /// Command for retrieving a product by their ID
    /// </summary>
    public record GetProductCommand : IRequest<GetProductResult>
    {
        /// <summary>
        /// The unique identifier of the product to retrieve
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of GetProductCommand
        /// </summary>
        /// <param name="id">The ID of the product to retrieve</param>
        public GetProductCommand(Guid id)
        {
            Id = id;
        }
    }

}
