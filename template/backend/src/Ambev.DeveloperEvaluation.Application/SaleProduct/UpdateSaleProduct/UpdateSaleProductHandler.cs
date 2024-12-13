using Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct;
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

namespace Ambev.DeveloperEvaluation.Application.SaleProducts.UpdateSaleProduct
{
    /// <summary>
    /// Handler for processing UpdateSaleProductCommand requests
    /// </summary>
    public class UpdateSaleProductHandler : IRequestHandler<UpdateSaleProductCommand, UpdateSaleProductResult>
    {
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateSaleProductHandler
        /// </summary>
        /// <param name="saleProductRepository">The saleProduct repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for UpdateSaleProductCommand</param>
        public UpdateSaleProductHandler(ISaleProductRepository saleProductRepository, IMapper mapper)
        {
            _saleProductRepository = saleProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateSaleProductCommand request
        /// </summary>
        /// <param name="command">The UpdateSaleProduct command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated saleProduct details</returns>
        public async Task<UpdateSaleProductResult> Handle(UpdateSaleProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateSaleProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);


            var saleProduct = _mapper.Map<SaleProduct>(command);

            var createdSaleProduct = await _saleProductRepository.UpdateAsync(saleProduct, cancellationToken);
            var result = _mapper.Map<UpdateSaleProductResult>(createdSaleProduct);
            return result;
        }
    }
}
