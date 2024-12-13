using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.DTOs.SaleProduct
{
    public class UpdateSaleProductDto
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductExternalId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public uint Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Discount { get; set; }
    }
}
