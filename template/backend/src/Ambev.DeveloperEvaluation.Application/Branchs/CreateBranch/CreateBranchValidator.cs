using FluentValidation;


namespace Ambev.DeveloperEvaluation.Application.Branchs.CreateBranch
{
    /// <summary>
    /// Validator for CreateBranchCommand that defines validation rules for branch creation command.
    /// </summary>
    public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateBranchCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, must be 1 or more characters
        /// - Description: Required, must be 3 or more characters
        /// </remarks>
        public CreateBranchCommandValidator()
        {
            RuleFor(branch => branch.Name).NotEmpty().MinimumLength(1);
            RuleFor(branch => branch.Description).NotEmpty().MinimumLength(3);
        }
    }
}
