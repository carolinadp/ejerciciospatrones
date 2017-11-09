using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class MexicoVisitor : Visitor
    {
        public override void CalculateClothTax(Cloth cloth)
        {
            Console.WriteLine("El impuesto de esta ropa {0} es de {1}", cloth.Name, cloth.Total * 0.16);
        }

        public override void CalculateFoodTax(Food food)
        {
            Console.WriteLine("El impuesto de esta comida {0} es de {1}", food.Name, food.Total * 0.05);
        }
    }
}
