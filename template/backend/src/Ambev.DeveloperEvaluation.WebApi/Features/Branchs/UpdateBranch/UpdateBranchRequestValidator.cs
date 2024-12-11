using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.UpdateBranch;

/// <summary>
/// Validator for UpdateBranchRequest that defines validation rules for branch creation.
/// </summary>
public class UpdateBranchRequestValidator : AbstractValidator<UpdateBranchRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateBranchRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, length between 1 or more characters
    /// - Description: Required, length between 3 or more characters
    /// </remarks>
    public UpdateBranchRequestValidator()
    {
        RuleFor(branch => branch.Name).NotEmpty().MinimumLength(1);
        RuleFor(branch => branch.Description).NotEmpty().MinimumLength(3);
    }
}