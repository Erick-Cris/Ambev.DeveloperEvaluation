
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct
{
    /// <summary>
    /// Command for creating a new saleProduct.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for creating a saleProduct, 
    /// including name, email, phone number and document. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateSaleProductResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateSaleProductCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>

    public class CreateSaleProductCommand : IRequest<CreateSaleProductResult>
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
        public uint Quantity { get; set; } = default;



        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleProductCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}

