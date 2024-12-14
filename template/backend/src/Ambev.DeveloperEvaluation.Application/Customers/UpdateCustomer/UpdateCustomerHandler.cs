using Ambev.DeveloperEvaluation.Application.Branchs.UpdateBranch;
using Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Events;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer
{
    /// <summary>
    /// Handler for processing UpdateCustomerCommand requests
    /// </summary>
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, UpdateCustomerResult>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        /// <summary>
        /// Initializes a new instance of UpdateCustomerHandler
        /// </summary>
        /// <param name="customerRepository">The customer repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for UpdateCustomerCommand</param>
        public UpdateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper, IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateCustomerCommand request
        /// </summary>
        /// <param name="command">The UpdateCustomer command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated customer details</returns>
        public async Task<UpdateCustomerResult> Handle(UpdateCustomerCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);


            var customer = _mapper.Map<Customer>(command);

            var updatedCustomer = await _customerRepository.UpdateAsync(customer, cancellationToken);
            var result = _mapper.Map<UpdateCustomerResult>(updatedCustomer);
            return result;
        }
    }
}
