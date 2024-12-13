using Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;


namespace Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct
{
    /// <summary>
    /// Command for updating a saleProduct.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for updating a saleProduct, 
    /// including name, email, phone number and document. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="UpdateSaleProductResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="UpdateSaleProductValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>

    public class UpdateSaleProductCommand : IRequest<UpdateSaleProductResult>
    {
        /// <summary>
        /// Gets or sets the GUID of the unique identificator of saleProduct to be updated.
        /// </summary>
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



        public ValidationResultDetail Validate()
        {
            var validator = new UpdateSaleProductCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}

