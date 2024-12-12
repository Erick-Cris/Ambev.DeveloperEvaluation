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
    }
}