
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Command for creating a new sale.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for creating a sale, 
    /// including name, email, phone number and document. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateSaleResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateSaleCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>

    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        /// <summary>
        /// Gets the sale's  customer id.
        /// Must not be null or empty.
        /// </summary>
        public Guid CustomerExternalId { get; set; }

        /// <summary>
        /// Gets the sale's  customer name.
        /// Must not be null or empty.
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's  customer document.
        /// Must not be null or empty.
        /// </summary>
        public string CustomerDocument { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's  branch id.
        /// Must not be null or empty.
        /// </summary>
        public Guid BranchExternalId { get; set; }

        /// <summary>
        /// Gets the sale's  branch name.
        /// Must not be null or empty.
        /// </summary>
        public string BranchName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's price.
        /// Must not be null or empty and could contain sale's total amount.
        /// </summary>
        public decimal TotalAmount { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets the sale's status.
        /// Must not be null and could contain sale's status.
        /// </summary>
        public SaleStatus Status { get; set; }

        public List<CreateSaleProductDto> SaleProducts { get; set; }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }


    }
}

