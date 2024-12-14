using Ambev.DeveloperEvaluation.Domain.Events;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.EventHandlers
{
    public class ProductUpdatedEventHandler : INotificationHandler<ProductUpdatedEvent>
    {
        private readonly ISaleProductRepository _saleProductRepository;

        public ProductUpdatedEventHandler(ISaleProductRepository saleProductRepository)
        {
            _saleProductRepository = saleProductRepository;
        }

        public async Task Handle(ProductUpdatedEvent notification, CancellationToken cancellationToken)
        {
            // Atualize o SalesContext conforme necessário
            var saleProducts = await _saleProductRepository.ListAsync(null, notification.ProductId, null, null, null, null, null, cancellationToken);
            if (saleProducts.Any())
            {
                foreach(var sp in saleProducts)
                {
                    sp.ProductName = notification.ProductName;
                    sp.ProductDescription = notification.ProductDescription;

                    var saleProduct = await _saleProductRepository.UpdateAsync(sp, cancellationToken);
                }
                
            }
        }
    }
}
