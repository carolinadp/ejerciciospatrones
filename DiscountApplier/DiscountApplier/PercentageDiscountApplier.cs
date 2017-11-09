using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    public class PercentageDiscountApplier : DiscountApplier
    {
        private const double DiscountPercentage= 10.0;
        public override void ApplyDiscount(Order order)
        {
            double total = order.GetTotal();
            if (total < 100)
            {
                Console.WriteLine("Se aplica descuento de {0}% y se cobra {1}.", DiscountPercentage, total * (100 - DiscountPercentage) / 100);
            } 
            else if (this.nextApplier != null)
            {
                this.nextApplier.ApplyDiscount(order);  
            }
        }
    }
}
