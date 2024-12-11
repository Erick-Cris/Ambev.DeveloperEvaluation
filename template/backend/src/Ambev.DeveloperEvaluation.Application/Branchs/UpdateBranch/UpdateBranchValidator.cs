using Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch;
using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch
{
    /// <summary>
    /// Validator for UpdateBranchCommand that defines validation rules for branch update command.
    /// </summary>
    public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateBranchCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be 1 or more characters
        /// - Description: Required, must be 3 or more characters
        /// </remarks>
        public UpdateBranchCommandValidator()
        {
            RuleFor(branch => branch.Name).NotEmpty().MinimumLength(1);
            RuleFor(branch => branch.Description).NotEmpty().MinimumLength(3);
        }
    }
}
