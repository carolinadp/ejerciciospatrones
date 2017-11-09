using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);

        public double Total { get; set; }

        public string Name { get; set; }
    }
}
