using Ambev.DeveloperEvaluation.WebApi.Features.Branchs.GetBranch;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.ListBranch;

/// <summary>
/// Validator for ListBranchRequest
/// </summary>
public class ListBranchRequestValidator : AbstractValidator<ListBranchRequest>
{
    /// <summary>
    /// Initializes validation rules for ListBranchRequest
    /// </summary>
    public ListBranchRequestValidator()
    {
        //RuleFor(x => x.Name)
        //    .NotEmpty()
        //    .WithMessage("Branch Name is required");
    }
}
