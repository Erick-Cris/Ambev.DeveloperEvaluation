using Ambev.DeveloperEvaluation.WebApi.Mappings;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale;

/// <summary>
/// Profile for mapping ListSale feature requests to commands
/// </summary>
public class ListSaleProfile : SaleProfile
{
    /// <summary>
    /// Initializes the mappings for ListSale feature
    /// </summary>
    public ListSaleProfile()
    {
        CreateMap<ListSaleRequest, Application.Sales.ListSale.ListSaleCommand>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.CustomerExternalId, opt => opt.MapFrom(src => src.CustomerExternalId))
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
            .ForMember(dest => dest.CustomerDocument, opt => opt.MapFrom(src => src.CustomerDocument))
            .ForMember(dest => dest.BranchExternalId, opt => opt.MapFrom(src => src.BranchExternalId))
            .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.BranchName))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));
    }
}
