using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.ListBranch
{
    /// <summary>
    /// Response model for ListBranch operation
    /// </summary>
    public class ListBranchResult
    {
        /// <summary>
        /// The unique identifier of the branch
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The branch's name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The branch's Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}