using Ambev.DeveloperEvaluation.Application.Branchs.CreateBranch;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.CreateBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and CreateBranchResponse
    /// </summary>
    public class CreateBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateBranch operation
        /// </summary>
        public CreateBranchProfile()
        {
            CreateMap<CreateBranchCommand, Branch>();
            CreateMap<Branch, CreateBranchResult>();
        }
    }
}
