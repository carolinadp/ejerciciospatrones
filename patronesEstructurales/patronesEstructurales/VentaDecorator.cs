using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    public class VentaDecorator : Decorator
    {
        public VentaDecorator(Producto producto) : base(producto)
        {
            this.producto.Compras++;
        }
    }
}
