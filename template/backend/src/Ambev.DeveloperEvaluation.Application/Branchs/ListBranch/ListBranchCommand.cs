using Ambev.DeveloperEvaluation.Application.Branchs.GetBranch;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.ListBranch
{
    /// <summary>
    /// Command for retrieving a branch's list
    /// </summary>
    public record ListBranchCommand : IRequest<List<ListBranchResult>>
    {

        /// <summary>
        /// The Name of the branch to retrieve
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The Decsription of the branch to retrieve
        /// </summary>
        public string Description { get; }


        /// <summary>
        /// Initializes a new instance of ListBranchCommand
        /// </summary>
        /// <param name="name">The name of the branch to retrieve</param>
        /// <param name="description">The description of the branch to retrieve</param>
        public ListBranchCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
