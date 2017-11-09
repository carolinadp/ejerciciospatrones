using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    public abstract class DiscountApplier
    {
        protected DiscountApplier nextApplier = null;

        public void SetNextApplier(DiscountApplier nextApplier)
        {
            this.nextApplier = nextApplier;
        }

        public abstract void ApplyDiscount(Order order);

    }
}
