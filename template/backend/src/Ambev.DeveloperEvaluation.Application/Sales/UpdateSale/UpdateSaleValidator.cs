using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale
{
    /// <summary>
    /// Validator for UpdateSaleCommand that defines validation rules for sale update command.
    /// </summary>
    public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSaleCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - CustomerName: Required, length between 3 and 300 characters
        /// - CustomerDocument: Required, valid pattern
        /// - BranchName: Required, length between 3 or more
        /// </remarks>
        public UpdateSaleCommandValidator()
        {
            RuleFor(sale => sale.CustomerName)
                .NotEmpty()
                .MinimumLength(3).WithMessage("CustomerName must be at least 3 characters long.")
                .MaximumLength(300).WithMessage("CustomerName cannot be longer than 300 characters.");

            RuleFor(sale => sale.CustomerDocument).SetValidator(new DocumentValidator());

            RuleFor(sale => sale.BranchName)
                .NotEmpty()
                .MinimumLength(1).WithMessage("BranchName must be at least 3 characters long.");
        }
    }
}
