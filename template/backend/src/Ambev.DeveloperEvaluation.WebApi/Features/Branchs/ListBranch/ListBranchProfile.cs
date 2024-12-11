using Ambev.DeveloperEvaluation.WebApi.Mappings;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.ListBranch;

/// <summary>
/// Profile for mapping ListBranch feature requests to commands
/// </summary>
public class ListBranchProfile : BranchProfile
{
    /// <summary>
    /// Initializes the mappings for ListBranch feature
    /// </summary>
    public ListBranchProfile()
    {
        CreateMap<ListBranchRequest, Application.Branchs.ListBranch.ListBranchCommand>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
    }
}
