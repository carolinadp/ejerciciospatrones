using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    class Program
    {
        static void Main(string[] args)
        {
            Balon balon = new Balon();
            balon.Tamano = 15;
            Decorator decorator = new DescuentoDecorator(balon);
            decorator.Mostrar();
        }
    }
}
