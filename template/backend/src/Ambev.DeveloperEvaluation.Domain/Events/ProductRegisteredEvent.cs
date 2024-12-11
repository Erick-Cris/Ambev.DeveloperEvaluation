using Ambev.DeveloperEvaluation.Domain.Entities;


namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class ProductRegisteredEvent
    {
        public Product Product { get; }

        public ProductRegisteredEvent(Product product)
        {
            Product = product;
        }
    }
}
