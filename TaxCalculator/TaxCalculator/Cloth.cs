using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class Cloth : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.CalculateClothTax(this);
        }
    }
}
