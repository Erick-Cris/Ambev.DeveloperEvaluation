using Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Application.Sales.ListSale;
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
        CreateMap<Application.Sales.CreateSale.CreateSaleProductDto, Application.Sales.CreateSale.CreateSaleProductDto>();
        CreateMap<Features.Sales.CreateSale.CreateSaleProductDto, Application.Sales.CreateSale.CreateSaleProductDto>();

        CreateMap<Sale, ListSaleResult>();
        CreateMap<SaleProduct, ListSaleProductResult>();
        CreateMap<ListSaleProductResult, Application.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
        CreateMap<ListSaleProductResult, Features.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
        CreateMap<SaleProduct, Application.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
        CreateMap<SaleProduct, Features.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
        CreateMap<Application.Sales.ListSale.ListSaleProductResponse, WebApi.Features.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
        CreateMap<Features.Sales.ListSale.ListSaleProductResponse, WebApi.Features.Sales.ListSale.ListSaleProductResponse>();//Erick - Resolver isso depois
    }
}