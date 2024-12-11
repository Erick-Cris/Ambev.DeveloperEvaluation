﻿using Ambev.DeveloperEvaluation.WebApi.Mappings;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.GetBranch;

/// <summary>
/// Profile for mapping GetBranch feature requests to commands
/// </summary>
public class GetBranchProfile : BranchProfile
{
    /// <summary>
    /// Initializes the mappings for GetBranch feature
    /// </summary>
    public GetBranchProfile()
    {
        CreateMap<Guid, Application.Branchs.GetBranch.GetBranchCommand>()
            .ConstructUsing(id => new Application.Branchs.GetBranch.GetBranchCommand(id));
    }
}