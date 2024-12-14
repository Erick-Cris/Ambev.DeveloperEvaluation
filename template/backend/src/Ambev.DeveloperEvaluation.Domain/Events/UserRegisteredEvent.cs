using MediatR;
using System;

namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class ProductUpdatedEvent : INotification
    {
        public Guid ProductId { get; }
        public string ProductName { get; }
        public string ProductDescription { get; }
        public decimal ProductPrice { get; }

        public ProductUpdatedEvent(Guid productId, string productName, string productDescription)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
        }
    }
}
