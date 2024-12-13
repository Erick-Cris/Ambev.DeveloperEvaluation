using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class SalesBusinessRules
    {
        public static decimal CalculateDiscount(uint quantity)
        {

            if (quantity >= 10 && quantity <= 20)
                return 20;
            else if (quantity >= 4 && quantity < 10)
                return 10;
            else if (quantity > 20)
                throw new Exception("The quantity of a product type cannot exceed 20 units.");
            else
                return 0;

        }

        public static decimal CalculateTotalAmount(List<Domain.Entities.SaleProduct> salesProducts)
        {
            decimal totalAmount = 0;
            foreach (var sp in salesProducts)
            {
                var saleProductTotalWithOutDiscount = sp.ProductPrice * sp.Quantity;

                decimal discountValue = saleProductTotalWithOutDiscount * (sp.Discount / 100);
                decimal saleProdutTotalWithDiscount = saleProductTotalWithOutDiscount - discountValue;

                totalAmount += saleProdutTotalWithDiscount;
            }



            return totalAmount;
        }
    }
}
