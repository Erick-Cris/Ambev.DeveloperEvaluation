﻿using Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.UpdateBranch;

/// <summary>
/// Profile for mapping between Application and API UpdateBranch responses
/// </summary>
public class UpdateBranchProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for UpdateBranch feature
    /// </summary>
    public UpdateBranchProfile()
    {
        CreateMap<UpdateBranchRequest, UpdateBranchCommand>();
        CreateMap<UpdateBranchResult, UpdateBranchResponse>();
    }
}