using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// Represents the response returned after successfully updating a product.
    /// </summary>
    /// <remarks>
    /// This response contains the data of the updated product,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the updated product.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated product in the system.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the updated product.
        /// </summary>
        /// <value>A name that identifies the updated product in the system.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the updated product.
        /// </summary>
        /// <value>A description that identifies the updated product in the system.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the updated product.
        /// </summary>
        /// <value>A price of the updated product in the system.</value>
        public decimal Price { get; set; }
    }
}
