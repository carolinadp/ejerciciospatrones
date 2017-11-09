using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    public class DirectDiscountApplier : DiscountApplier
    {
        private const double MinimumTotal = 500.0;
        private const double DiscountToApply = 50.0;

        public override void ApplyDiscount(Order order)
        {
            double total = order.GetTotal();
            if(total > MinimumTotal)
            {
                total -= DiscountToApply;
                Console.WriteLine("Se aplica descuento de {0} y se cobra {1}", DiscountToApply, total);
            }
            else if (this.nextApplier != null)
            {
                this.nextApplier.ApplyDiscount(order);
            }
        }
    }
}
