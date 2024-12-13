using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct
{
    /// <summary>
    /// Represents the response returned after successfully updating a saleProduct.
    /// </summary>
    /// <remarks>
    /// This response contains the data of the updated saleProduct,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateSaleProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the updated saleProduct.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated saleProduct in the system.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets the saleProduct's  sale id.
        /// Must not be null or empty.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets the saleProduct's external product id.
        /// Must not be null or empty.
        /// </summary>
        public Guid ProductExternalId { get; set; }

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
        public decimal ProductPrice { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the saleProduct's  product discount %.
        /// Must not be null or empty.
        /// </summary>
        public decimal Discount { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the saleProduct's  prduct quantity.
        /// Must not be null or empty.
        /// </summary>
        public uint Quantity { get; set; } = default;
    }
}
