using Ambev.DeveloperEvaluation.WebApi.Mappings;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Profile for mapping GetSale feature requests to commands
/// </summary>
public class GetSaleProfile : SaleProfile
{
    /// <summary>
    /// Initializes the mappings for GetSale feature
    /// </summary>
    public GetSaleProfile()
    {
        CreateMap<Guid, Application.Sales.GetSale.GetSaleCommand>()
            .ConstructUsing(id => new Application.Sales.GetSale.GetSaleCommand(id));
    }
}