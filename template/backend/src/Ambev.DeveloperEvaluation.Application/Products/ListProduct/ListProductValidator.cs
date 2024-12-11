using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct
{
    /// <summary>
    /// Validator for ListProductCommand
    /// </summary>
    public class ListProductValidator : AbstractValidator<ListProductCommand>
    {
        /// <summary>
        /// Initializes validation rules for ListProductCommand
        /// </summary>
        public ListProductValidator()
        {
            //RuleFor(x => x.Name)
            //.NotEmpty()
            //.WithMessage("Product Name is required");
        }
    }
}
