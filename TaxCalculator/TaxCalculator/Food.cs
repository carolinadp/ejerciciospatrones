using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class Food : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.CalculateFoodTax(this);
        }
    }
}
