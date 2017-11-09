using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    public class TwoByOneDiscountApplier : DiscountApplier
    {
        public override void ApplyDiscount(Order order)
        {
            if (order.Products.Count() >= 2)
            {
                var orderedProducts = order.Products.OrderBy(p => p.Price);
                var productsToDiscount = orderedProducts.Count() / 2;
                int counter = 0;
                double total = 0.0;
                foreach (var prod in orderedProducts)
                {
                    counter++;
                    if (counter > productsToDiscount)
                    {
                        total += prod.Price;
                    }
                }

                Console.WriteLine("Se descontaron {0} productos y se cobra {1}.", productsToDiscount, total);
            }
            else if (this.nextApplier != null)
            {
                this.nextApplier.ApplyDiscount(order);
            }
        }
    }
}
