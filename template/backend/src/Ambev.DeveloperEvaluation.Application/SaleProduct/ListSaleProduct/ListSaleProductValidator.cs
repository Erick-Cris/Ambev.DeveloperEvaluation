using Ambev.DeveloperEvaluation.Application.SaleProducts.GetSaleProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct
{
    /// <summary>
    /// Validator for ListSaleProductCommand
    /// </summary>
    public class ListSaleProductValidator : AbstractValidator<ListSaleProductCommand>
    {
        /// <summary>
        /// Initializes validation rules for ListSaleProductCommand
        /// </summary>
        public ListSaleProductValidator()
        {
            //RuleFor(x => x.Name)
            //.NotEmpty()
            //.WithMessage("SaleProduct Name is required");
        }
    }
}
