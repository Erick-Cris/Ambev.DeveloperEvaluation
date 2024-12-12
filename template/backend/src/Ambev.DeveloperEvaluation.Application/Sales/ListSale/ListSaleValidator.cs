using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSale
{
    /// <summary>
    /// Validator for ListSaleCommand
    /// </summary>
    public class ListSaleValidator : AbstractValidator<ListSaleCommand>
    {
        /// <summary>
        /// Initializes validation rules for ListSaleCommand
        /// </summary>
        public ListSaleValidator()
        {
            //RuleFor(x => x.Name)
            //.NotEmpty()
            //.WithMessage("Sale Name is required");
        }
    }
}
