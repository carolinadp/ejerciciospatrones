using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    public class Balon : Producto
    {
        public int Tamano { get; set; }
        public override void Mostrar()
        {
            Console.WriteLine("Un balon tamano " + this.Tamano + " se ha vendido " + this.Compras + " veces.");
        }
    }
}
