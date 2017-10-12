using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    public class Decorator : Producto
    {
        protected Producto producto = null;

        public Decorator(Producto producto)
        {
            this.producto = producto;
        }
        public override void Mostrar()
        {
            this.producto.Mostrar();
        }
    }
}
