using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct
{
    /// <summary>
    /// Represents the response returned after successfully creating a new saleProduct.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created saleProduct,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateSaleProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created saleProduct.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created saleProduct in the system.</value>
        public Guid Id { get; set; }
    }
}
