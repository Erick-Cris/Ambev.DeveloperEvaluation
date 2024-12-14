
using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;
using Ambev.DeveloperEvaluation.Application.Customers.ListCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Customers.GetCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerRequest, CreateCustomerCommand>();
        CreateMap<GetCustomerRequest, GetCustomerCommand>();
        CreateMap<GetCustomerResult, GetCustomerResponse>();
        CreateMap<ListCustomerResult, ListCustomerResponse>();
    }
}