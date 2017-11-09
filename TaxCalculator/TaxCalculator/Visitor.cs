using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public abstract class Visitor
    {
        public abstract void CalculateFoodTax(Food food);

        public abstract void CalculateClothTax(Cloth cloth);
    }
}
