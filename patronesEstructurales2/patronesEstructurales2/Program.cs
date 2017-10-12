using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace patronesEstructurales2
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite raiz = new Composite("Frida Kahlo", 1000);

            Composite comp1 = raiz.Agregar("Pedrito", 3000);

            Composite hoja1 = raiz.Agregar("Laura", 5000);

            comp1.Agregar("Antonio", 1500);
            comp1.Agregar("Raul", 15000);

            raiz.Mostrar();
        }
    }
}
