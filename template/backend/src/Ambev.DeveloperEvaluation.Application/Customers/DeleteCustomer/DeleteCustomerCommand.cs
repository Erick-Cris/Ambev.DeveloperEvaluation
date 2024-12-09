using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.DeleteCustomer
{
    /// <summary>
    /// Command for deleting a customer
    /// </summary>
    public record DeleteCustomerCommand : IRequest<DeleteCustomerResponse>
    {
        /// <summary>
        /// The unique identifier of the customer to delete
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of DeleteCustomerCommand
        /// </summary>
        /// <param name="id">The ID of the customer to delete</param>
        public DeleteCustomerCommand(Guid id)
        {
            Id = id;
        }
    }

}
