using Ambev.DeveloperEvaluation.Application.Products.ListProduct;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct
{
    /// <summary>
    /// Handler for processing ListProductCommand requests
    /// </summary>
    public class ListProductHandler : IRequestHandler<ListProductCommand, List<ListProductResult>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListProductHandler
        /// </summary>
        /// <param name="productRepository">The product repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for ListProductCommand</param>
        public ListProductHandler(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the ListProductCommand request
        /// </summary>
        /// <param name="request">The ListProduct command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The product details if found</returns>
        public async Task<List<ListProductResult>> Handle(ListProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new ListProductValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var products = await _productRepository.ListAsync(request.Name, request.Description, request.Price, cancellationToken);
            //if (product == null)
            //    throw new KeyNotFoundException($"Product with ID {request.Id} not found");

            return _mapper.Map<List<ListProductResult>>(products);
        }
    }
}
