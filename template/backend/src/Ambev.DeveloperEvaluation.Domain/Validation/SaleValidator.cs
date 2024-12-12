using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
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