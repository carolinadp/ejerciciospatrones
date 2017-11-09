using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calculator = new TaxCalculator();
            Cloth playera = new Cloth { Name = "playera", Total = 100 };
            Cloth jeans = new Cloth { Name = "jeans", Total = 300 };
            Food platano = new Food { Name = "platano", Total = 20 };
            Food carne = new Food { Name = "carne", Total = 250 };

            calculator.Attach(playera);
            calculator.Attach(jeans);
            calculator.Attach(platano);
            calculator.Attach(carne);

            calculator.Accept(new MexicoVisitor());

            Console.ReadLine();

        }
    }
}
