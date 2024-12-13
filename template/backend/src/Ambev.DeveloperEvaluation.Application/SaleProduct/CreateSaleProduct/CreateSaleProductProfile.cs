using Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct
{
    /// <summary>
    /// Profile for mapping between SaleProduct entity and CreateSaleProductResponse
    /// </summary>
    public class CreateSaleProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateSaleProduct operation
        /// </summary>
        public CreateSaleProductProfile()
        {
            CreateMap<CreateSaleProductCommand, SaleProduct>();
            CreateMap<SaleProduct, CreateSaleProductResult>();
        }
    }
}
