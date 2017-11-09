using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplier
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountApplier percentageApplier = new PercentageDiscountApplier();
            DiscountApplier twoByOneApplier = new TwoByOneDiscountApplier();
            DiscountApplier directApplier = new DirectDiscountApplier();

            percentageApplier.SetNextApplier(twoByOneApplier);
            twoByOneApplier.SetNextApplier(directApplier);

            Order firstOrder = new Order();
            firstOrder.Products.Add(new Product
            {
                Name = "Calcetines",
                Price = 20
            });

            percentageApplier.ApplyDiscount(firstOrder);

            Order secondOrder = new Order();
            secondOrder.Products.Add(new Product
            {
                Name = "Crayolas",
                Price = 50
            });
            secondOrder.Products.Add(new Product
            {
                Name = "Cartulinas",
                Price = 60
            });

            percentageApplier.ApplyDiscount(secondOrder);

            Order thirdOrder = new Order();
            thirdOrder.Products.Add(new Product
            {
                Name = "Microcontrolador",
                Price = 600
            });

            percentageApplier.ApplyDiscount(thirdOrder);

            Order fourthOrder = new Order();
            fourthOrder.Products.Add(new Product
            {
                Name = "Lets",
                Price = 400
            });

            percentageApplier.ApplyDiscount(fourthOrder);
            Console.ReadLine();
        }
    }
}
