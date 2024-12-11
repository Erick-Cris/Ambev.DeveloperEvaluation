using Ambev.DeveloperEvaluation.Application.Branchs.CreateBranch;
using Ambev.DeveloperEvaluation.Application.Branchs.GetBranch;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.ListBranch
{
    /// <summary>
    /// Profile for mapping between Branch entity and ListBranchResponse
    /// </summary>
    public class ListBranchProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for ListBranch operation
        /// </summary>
        public ListBranchProfile()
        {
            CreateMap<Branch, ListBranchResult>();
        }
    }
}