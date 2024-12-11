using Ambev.DeveloperEvaluation.Application.Branchs.GetBranch;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.ListBranch
{
    /// <summary>
    /// Validator for ListBranchCommand
    /// </summary>
    public class ListBranchValidator : AbstractValidator<ListBranchCommand>
    {
        /// <summary>
        /// Initializes validation rules for ListBranchCommand
        /// </summary>
        public ListBranchValidator()
        {
            //RuleFor(x => x.Name)
            //.NotEmpty()
            //.WithMessage("Branch Name is required");
        }
    }
}
