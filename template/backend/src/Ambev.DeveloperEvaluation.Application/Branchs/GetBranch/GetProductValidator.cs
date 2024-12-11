using Ambev.DeveloperEvaluation.Application.Branchs.GetBranch;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.GetBranch
{
    /// <summary>
    /// Validator for GetBranchCommand
    /// </summary>
    public class GetBranchValidator : AbstractValidator<GetBranchCommand>
    {
        /// <summary>
        /// Initializes validation rules for GetBranchCommand
        /// </summary>
        public GetBranchValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Branch ID is required");
        }
    }
}
