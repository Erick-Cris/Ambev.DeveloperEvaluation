using Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct;
using Ambev.DeveloperEvaluation.Application.SaleProducts.GetSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct
{
    /// <summary>
    /// Profile for mapping between SaleProduct entity and ListSaleProductResponse
    /// </summary>
    public class ListSaleProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for ListSaleProduct operation
        /// </summary>
        public ListSaleProductProfile()
        {
            CreateMap<SaleProduct, ListSaleProductResult>();
        }
    }
}