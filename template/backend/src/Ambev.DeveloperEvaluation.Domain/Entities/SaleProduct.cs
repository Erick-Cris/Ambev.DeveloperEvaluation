using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a SaleProduct in thebusiness rule.
    /// This entity follows domain-driven design principles and includes business rules validation.
    /// </summary>
    public class SaleProduct : BaseEntity
    {

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
        public uint Quantity { get; set; } = default ;

        /// <summary>
        /// Gets the date and time when the saleProduct was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time of the last update to the saleProduct's information.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Initializes a new instance of the SaleProduct class.
        /// </summary>

        public SaleProduct()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Performs validation of the user entity using the UserValidator rules.
        /// </summary>
        /// <returns>
        /// A <see cref="ValidationResultDetail"/> containing:
        /// - IsValid: Indicates whether all validation rules passed
        /// - Errors: Collection of validation errors if any rules failed
        /// </returns>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">ProductName value and length</list>
        /// <list type="bullet">ProductDescription format and length</list>
        /// 
        /// </remarks>
        public ValidationResultDetail Validate()
        {
            var validator = new SaleProductValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}