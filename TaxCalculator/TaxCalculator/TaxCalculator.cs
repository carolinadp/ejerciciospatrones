using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class TaxCalculator
    {
        private List<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            this.elements.Add(element);
        }

        public void Detach(Element element)
        {
            this.elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (var element in this.elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
