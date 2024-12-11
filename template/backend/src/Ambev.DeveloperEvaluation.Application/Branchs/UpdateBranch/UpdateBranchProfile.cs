using Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and UpdateBranchResponse
    /// </summary>
    public class UpdateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateBranch operation
        /// </summary>
        public UpdateBranchProfile()
        {
            CreateMap<UpdateBranchCommand, Branch>();
            CreateMap<Branch, UpdateBranchResult>();
        }
    }
}
