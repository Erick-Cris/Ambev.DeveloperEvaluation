using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct;
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

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale
{
    /// <summary>
    /// Handler for processing UpdateSaleCommand requests
    /// </summary>
    public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateSaleHandler
        /// </summary>
        /// <param name="saleRepository">The sale repository</param>
        /// <param name="saleProductRepository">The sale repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for UpdateSaleCommand</param>
        public UpdateSaleHandler(ISaleRepository saleRepository, ISaleProductRepository saleProductRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _saleProductRepository = saleProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateSaleCommand request
        /// </summary>
        /// <param name="command">The UpdateSale command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated sale details</returns>
        public async Task<UpdateSaleResult> Handle(UpdateSaleCommand command, CancellationToken cancellationToken)
        {
            var validator = new UpdateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sale = _mapper.Map<Sale>(command);

            List<SaleProduct> saleProductListToReturn = new List<SaleProduct>();

            foreach (var saleProductDto in command.SaleProducts)
            {
                saleProductDto.Discount = SalesBusinessRules.CalculateDiscount(saleProductDto.Quantity);
                var saleProduct = _mapper.Map<SaleProduct>(saleProductDto);
                saleProduct.SaleId = sale.Id;
                
                if (saleProduct.Id == Guid.Empty)
                {
                    saleProductListToReturn.Add( await _saleProductRepository.CreateAsync(saleProduct, cancellationToken));
                }
                else
                {
                    saleProductListToReturn.Add(await _saleProductRepository.UpdateAsync(saleProduct, cancellationToken));
                }
            }
            sale.TotalAmount = SalesBusinessRules.CalculateTotalAmount(saleProductListToReturn);
            var updatedSale = await _saleRepository.UpdateAsync(sale, cancellationToken);
            var result = _mapper.Map<UpdateSaleResult>(updatedSale);
            result.SaleProducts = _mapper.Map<List<UpdateSaleProductDto>>(saleProductListToReturn);
            return result;
        }
    }
}
