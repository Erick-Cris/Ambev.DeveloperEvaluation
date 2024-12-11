using Ambev.DeveloperEvaluation.Application.Branchs.DeleteBranch;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.DeleteBranch
{
    /// <summary>
    /// Validator for DeleteBranchCommand
    /// </summary>
    public class DeleteBranchValidator : AbstractValidator<DeleteBranchCommand>
    {
        /// <summary>
        /// Initializes validation rules for DeleteBranchCommand
        /// </summary>
        public DeleteBranchValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Branch ID is required");
        }
    }
}
