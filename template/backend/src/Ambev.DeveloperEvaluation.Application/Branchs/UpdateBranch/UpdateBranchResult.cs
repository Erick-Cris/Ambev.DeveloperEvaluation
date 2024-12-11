using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch
{
    /// <summary>
    /// Represents the response returned after successfully updating a branch.
    /// </summary>
    /// <remarks>
    /// This response contains the data of the updated branch,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateBranchResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the updated branch.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated branch in the system.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the updated branch.
        /// </summary>
        /// <value>A name that identifies the updated branch in the system.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the updated branch.
        /// </summary>
        /// <value>A description that identifies the updated branch in the system.</value>
        public string Description { get; set; }
    }
}
