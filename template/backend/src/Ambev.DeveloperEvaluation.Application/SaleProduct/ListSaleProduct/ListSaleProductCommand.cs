using Ambev.DeveloperEvaluation.Application.SaleProducts.GetSaleProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct
{
    /// <summary>
    /// Command for retrieving a saleProduct's list
    /// </summary>
    public record ListSaleProductCommand : IRequest<List<ListSaleProductResult>>
    {

        /// <summary>
        /// Gets the saleProduct's  sale id.
        /// Must not be null or empty.
        /// </summary>
        public Guid? SaleId { get; set; }

        /// <summary>
        /// Gets the saleProduct's external product id.
        /// Must not be null or empty.
        /// </summary>
        public Guid? ProductExternalId { get; set; }

        /// <summary>
        /// Gets the saleProduct's  product name.
        /// Must not be null or empty.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the saleProduct's  product description.
        /// Must not be null or empty.
        /// </summary>
        public string ProductDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets the saleProduct's  product price.
        /// Must not be null or empty.
        /// </summary>
        public decimal? ProductPrice { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the saleProduct's  product discount %.
        /// Must not be null or empty.
        /// </summary>
        public decimal? Discount { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the saleProduct's  prduct quantity.
        /// Must not be null or empty.
        /// </summary>
        public uint? Quantity { get; set; } = default;

        /// <summary>
        /// Initializes a new instance of ListSaleProductCommand
        /// </summary>
        /// <param name="idSale">The sale's id of the saleProduct to retrieve</param>
        /// <param name="idExternalProduct">The external id of the product to retrieve</param>
        /// <param name="productName">The name of the product to retrieve</param>
        /// <param name="productDescription">The description of the product to retrieve</param>
        /// <param name="productPrice">The price of the product to retrieve</param>
        /// <param name="discount">The discount of the product to retrieve</param>
        /// <param name="quantity">The quantity of the product to retrieve</param>
        public ListSaleProductCommand(Guid? saleId, 
            Guid? productExternalId, 
            string productName, 
            string productDescription, 
            decimal? productPrice,
            decimal? discount,
            uint? quantity)
        {
            SaleId = saleId;
            ProductExternalId = productExternalId;
            ProductName = productDescription;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            Discount = discount;
            Quantity = quantity;
        }
    }

}
