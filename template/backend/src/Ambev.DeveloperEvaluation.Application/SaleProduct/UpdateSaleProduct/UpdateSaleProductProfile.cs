using Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct
{
    /// <summary>
    /// Profile for mapping between SaleProduct entity and UpdateSaleProductResponse
    /// </summary>
    public class UpdateSaleProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateSaleProduct operation
        /// </summary>
        public UpdateSaleProductProfile()
        {
            CreateMap<UpdateSaleProductCommand, SaleProduct>();
            CreateMap<SaleProduct, UpdateSaleProductResult>();
        }
    }
}
