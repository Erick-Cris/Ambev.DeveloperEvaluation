﻿using Ambev.DeveloperEvaluation.Application.Customers.ListCustomer;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.ListCustomer
{
    /// <summary>
    /// Handler for processing ListCustomerCommand requests
    /// </summary>
    public class ListCustomerHandler : IRequestHandler<ListCustomerCommand, List<ListCustomerResult>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListCustomerHandler
        /// </summary>
        /// <param name="customerRepository">The customer repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for ListCustomerCommand</param>
        public ListCustomerHandler(
            ICustomerRepository customerRepository,
            IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the ListCustomerCommand request
        /// </summary>
        /// <param name="request">The ListCustomer command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The customer details if found</returns>
        public async Task<List<ListCustomerResult>> Handle(ListCustomerCommand request, CancellationToken cancellationToken)
        {
            var validator = new ListCustomerValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var customers = await _customerRepository.ListAsync(request.Name, request.Document, request.Phone, request.Email, cancellationToken);
            //if (customer == null)
            //    throw new KeyNotFoundException($"Customer with ID {request.Id} not found");

            return _mapper.Map<List<ListCustomerResult>>(customers);
        }
    }
}
