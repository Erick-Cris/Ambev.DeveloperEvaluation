using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct
{
    /// <summary>
    /// Profile for mapping between Product entity and ListProductResponse
    /// </summary>
    public class ListProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for ListProduct operation
        /// </summary>
        public ListProductProfile()
        {
            CreateMap<Product, ListProductResult>();
        }
    }
}