using Ambev.DeveloperEvaluation.WebApi.Mappings;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;

/// <summary>
/// Profile for mapping ListCustomer feature requests to commands
/// </summary>
public class ListCustomerProfile : CustomerProfile
{
    /// <summary>
    /// Initializes the mappings for ListCustomer feature
    /// </summary>
    public ListCustomerProfile()
    {
        CreateMap<ListCustomerRequest, Application.Customers.ListCustomer.ListCustomerCommand>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Document, opt => opt.MapFrom(src => src.Document))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone));
    }
}
