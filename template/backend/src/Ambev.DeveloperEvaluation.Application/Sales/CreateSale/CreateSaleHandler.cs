using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Handler for processing CreateSaleCommand requests
    /// </summary>
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly ISaleProductRepository _saleProductRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateSaleHandler
        /// </summary>
        /// <param name="saleRepository">The sale repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for CreateSaleCommand</param>
        public CreateSaleHandler(ISaleRepository saleRepository, ISaleProductRepository saleProductRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _saleProductRepository = saleProductRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the CreateSaleCommand request
        /// </summary>
        /// <param name="command">The CreateSale command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale details</returns>
        public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);


            // Cria a Sale
            var sale = new Sale
            {
                CustomerExternalId = command.CustomerExternalId,
                CustomerName = command.CustomerName,
                CustomerDocument = command.CustomerDocument,
                BranchExternalId = command.BranchExternalId,
                BranchName = command.BranchName,
                TotalAmount = command.TotalAmount,
                Status = SaleStatus.Active
            };

            var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);

            // Cria os SaleProducts associados e aplica as regras de negócio
            var saleProducts = new List<SaleProduct>();
            foreach (var saleProductDto in command.SaleProducts)
            {
                var discount = SalesBusinessRules.CalculateDiscount(saleProductDto.Quantity);
                var saleProduct = new SaleProduct
                {
                    SaleId = createdSale.Id,
                    ProductExternalId = saleProductDto.ProductExternalId,
                    ProductName = saleProductDto.ProductName,
                    ProductDescription = saleProductDto.ProductDescription,
                    Quantity = saleProductDto.Quantity,
                    ProductPrice = saleProductDto.ProductPrice,
                    Discount = discount
                };

                saleProducts.Add(saleProduct);
                await _saleProductRepository.CreateAsync(saleProduct, cancellationToken);
            }

            // Calcula o valor total da venda
            sale.TotalAmount = SalesBusinessRules.CalculateTotalAmount(saleProducts);
            await _saleRepository.UpdateAsync(sale, cancellationToken);

            var result = _mapper.Map<CreateSaleResult>(createdSale);
            return result;

        }
    }
}
