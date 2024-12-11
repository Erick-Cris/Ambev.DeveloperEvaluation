using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Branchs.CreateBranch;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.CreateBranch;

/// <summary>
/// Validator for CreateBranchRequest that defines validation rules for branch creation.
/// </summary>
public class CreateBranchRequestValidator : AbstractValidator<CreateBranchRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateBranchRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, length between 1 or more characters
    /// - Description: Required, length between 3 or more characters
    /// </remarks>
    public CreateBranchRequestValidator()
    {
        RuleFor(branch => branch.Name).NotEmpty().MinimumLength(1);
        RuleFor(branch => branch.Description).NotEmpty().MinimumLength(3);
    }
}