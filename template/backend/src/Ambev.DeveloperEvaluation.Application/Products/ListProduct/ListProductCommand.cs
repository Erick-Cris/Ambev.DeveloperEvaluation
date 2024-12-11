using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct
{
    /// <summary>
    /// Command for retrieving a product's list
    /// </summary>
    public record ListProductCommand : IRequest<List<ListProductResult>>
    {

        /// <summary>
        /// The Name of the product to retrieve
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The Decsription of the product to retrieve
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The Decsription of the product to retrieve
        /// </summary>
        public decimal? Price { get; }

        /// <summary>
        /// Initializes a new instance of ListProductCommand
        /// </summary>
        /// <param name="name">The name of the product to retrieve</param>
        /// <param name="description">The description of the product to retrieve</param>
        /// <param name="price">The price of the product to retrieve</param>
        public ListProductCommand(string name, string description, decimal? price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }

}
