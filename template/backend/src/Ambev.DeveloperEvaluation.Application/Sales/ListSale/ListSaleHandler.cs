using Ambev.DeveloperEvaluation.Application.Sales.ListSale;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSale
{
    /// <summary>
    /// Handler for processing ListSaleCommand requests
    /// </summary>
    public class ListSaleHandler : IRequestHandler<ListSaleCommand, List<ListSaleResult>>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListSaleHandler
        /// </summary>
        /// <param name="saleRepository">The sale repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for ListSaleCommand</param>
        public ListSaleHandler(
            ISaleRepository saleRepository,
            IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the ListSaleCommand request
        /// </summary>
        /// <param name="request">The ListSale command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The sale details if found</returns>
        public async Task<List<ListSaleResult>> Handle(ListSaleCommand request, CancellationToken cancellationToken)
        {
            var validator = new ListSaleValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sales = await _saleRepository.ListAsync(
                request.CustomerExternalId,
                request.CustomerName,
                request.CustomerDocument,
                request.BranchExternalId,
                request.BranchName,
                request.Status,
                request.TotalAmount,
                request.CreatedAt,
                cancellationToken);
            //if (sale == null)
            //    throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            return _mapper.Map<List<ListSaleResult>>(sales);
        }
    }
}
