using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer
{
    /// <summary>
    /// Command for retrieving a user by their ID
    /// </summary>
    public record GetCustomerCommand : IRequest<GetCustomerResult>
    {
        /// <summary>
        /// The unique identifier of the customer to retrieve
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of GetCustomerCommand
        /// </summary>
        /// <param name="id">The ID of the customer to retrieve</param>
        public GetCustomerCommand(Guid id)
        {
            Id = id;
        }
    }

}
