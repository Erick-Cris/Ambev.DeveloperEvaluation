using Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.CreateSaleProduct
{
    /// <summary>
    /// Handler for processing CreateSaleProductCommand requests
    /// </summary>
    public class CreateSaleProductHandler : IRequestHandler<CreateSaleProductCommand, CreateSaleProductResult>
    {
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateSaleProductHandler
        /// </summary>
        /// <param name="saleProductRepository">The saleProduct repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for CreateSaleProductCommand</param>
        public CreateSaleProductHandler(ISaleProductRepository saleProductRepository, IMapper mapper)
        {
            _saleProductRepository = saleProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the CreateSaleProductCommand request
        /// </summary>
        /// <param name="command">The CreateSaleProduct command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created saleProduct details</returns>
        public async Task<CreateSaleProductResult> Handle(CreateSaleProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);


            var saleProduct = _mapper.Map<SaleProduct>(command);

            var createdSaleProduct = await _saleProductRepository.CreateAsync(saleProduct, cancellationToken);
            var result = _mapper.Map<CreateSaleProductResult>(createdSaleProduct);
            return result;
        }
    }
}
