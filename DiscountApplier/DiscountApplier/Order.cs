using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public Order()
        {
            this.Products = new List<Product>();
        }
        public double GetTotal()
        {
            return this.Products.Sum(p => p.Price);
        }
    }
}
