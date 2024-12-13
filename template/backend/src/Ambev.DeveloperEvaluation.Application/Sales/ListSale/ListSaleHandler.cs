using Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSale
{
    /// <summary>
    /// Handler for processing ListSaleCommand requests
    /// </summary>
    public class ListSaleHandler : IRequestHandler<ListSaleCommand, List<ListSaleResult>>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListSaleHandler
        /// </summary>
        /// <param name="saleRepository">The sale repository</param>
        /// <param name="saleProductRepository">The sale repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        public ListSaleHandler(
            ISaleRepository saleRepository,
            ISaleProductRepository saleProductRepository,
            IMapper mapper)
        {
            _saleRepository = saleRepository;
            _saleProductRepository = saleProductRepository;
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

            var saleResults = _mapper.Map<List<ListSaleResult>>(sales);

            foreach (var saleResult in saleResults)
            {
                var saleProducts = await _saleProductRepository.ListAsync(
                null,
                null,
                null,
                null,
                null,
                null,
                cancellationToken);

                saleProducts = saleProducts.Where(x => x.SaleId == saleResult.Id).ToList();
                saleResult.SaleProducts = _mapper.Map<List<ListSaleProductResponse>>(saleProducts); ;
            }

            return saleResults;
        }
    }
}
