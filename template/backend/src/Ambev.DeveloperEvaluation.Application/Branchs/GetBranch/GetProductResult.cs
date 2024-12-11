using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.GetBranch
{
    /// <summary>
    /// Response model for GetBranch operation
    /// </summary>
    public class GetBranchResult
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