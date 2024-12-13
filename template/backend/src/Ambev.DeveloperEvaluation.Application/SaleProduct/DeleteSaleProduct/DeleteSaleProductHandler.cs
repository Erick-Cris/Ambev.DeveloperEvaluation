using Ambev.DeveloperEvaluation.Application.SaleProducts.DeleteSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;


namespace Ambev.DeveloperEvaluation.Application.SaleProducts.DeleteSaleProduct
{
    /// <summary>
    /// Handler for processing DeleteSaleProductCommand requests
    /// </summary>
    public class DeleteSaleProductHandler : IRequestHandler<DeleteSaleProductCommand, DeleteSaleProductResponse>
    {
        private readonly ISaleProductRepository _saleProductRepository;

        /// <summary>
        /// Initializes a new instance of DeleteSaleProductHandler
        /// </summary>
        /// <param name="saleProductRepository">The saleProduct repository</param>
        /// <param name="validator">The validator for DeleteSaleProductCommand</param>
        public DeleteSaleProductHandler(
            ISaleProductRepository saleProductRepository)
        {
            _saleProductRepository = saleProductRepository;
        }

        /// <summary>
        /// Handles the DeleteSaleProductCommand request
        /// </summary>
        /// <param name="request">The DeleteSaleProduct command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The result of the delete operation</returns>
        public async Task<DeleteSaleProductResponse> Handle(DeleteSaleProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteSaleProductValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var success = await _saleProductRepository.DeleteAsync(request.Id, cancellationToken);
            if (!success)
                throw new KeyNotFoundException($"SaleProduct with ID {request.Id} not found");

            return new DeleteSaleProductResponse { Success = true };
        }
    }
}
