using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    public abstract class Producto
    {
        public int Compras { set; get; }
        public double Precio { get; set; }
        public abstract void Mostrar();
    }
}
