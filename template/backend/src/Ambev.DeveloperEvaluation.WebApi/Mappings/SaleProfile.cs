using Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Application.Sales.ListSale;
using Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class SaleProfile : Profile
{
    public SaleProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>();
        CreateMap<GetSaleRequest, GetSaleCommand>();
        CreateMap<GetSaleResult, GetSaleResponse>();
        CreateMap<ListSaleRequest, ListSaleCommand>();
        CreateMap<ListSaleResult, ListSaleResponse>();
        CreateMap<CreateSaleProductDto, CreateSaleProductDto>();
        CreateMap<UpdateSaleProductDto, SaleProduct>();
        CreateMap<SaleProduct, UpdateSaleProductDto>();

        CreateMap<Sale, ListSaleResult>();
        CreateMap<SaleProduct, ListSaleProductResult>();
        CreateMap<ListSaleProductResult, ListSaleProductResponse>();
        CreateMap<SaleProduct, ListSaleProductResponse>();//Erick - Resolver isso depois
    }
}