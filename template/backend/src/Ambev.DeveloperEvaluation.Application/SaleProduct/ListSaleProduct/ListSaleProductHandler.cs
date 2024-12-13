using Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.ListSaleProduct
{
    /// <summary>
    /// Handler for processing ListSaleProductCommand requests
    /// </summary>
    public class ListSaleProductHandler : IRequestHandler<ListSaleProductCommand, List<ListSaleProductResult>>
    {
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListSaleProductHandler
        /// </summary>
        /// <param name="saleProductRepository">The saleProduct repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for ListSaleProductCommand</param>
        public ListSaleProductHandler(
            ISaleProductRepository saleProductRepository,
            IMapper mapper)
        {
            _saleProductRepository = saleProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the ListSaleProductCommand request
        /// </summary>
        /// <param name="request">The ListSaleProduct command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The saleProduct details if found</returns>
        public async Task<List<ListSaleProductResult>> Handle(ListSaleProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new ListSaleProductValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var saleProducts = await _saleProductRepository.ListAsync(
                request.ProductExternalId, 
                request.ProductName, 
                request.ProductDescription, 
                request.ProductPrice, 
                request.Discount, 
                request.Quantity, 
                cancellationToken);
            //if (saleProduct == null)
            //    throw new KeyNotFoundException($"SaleProduct with ID {request.Id} not found");

            return _mapper.Map<List<ListSaleProductResult>>(saleProducts);
        }
    }
}
