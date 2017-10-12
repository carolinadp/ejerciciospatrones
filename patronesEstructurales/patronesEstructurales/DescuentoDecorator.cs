using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesEstructurales
{
    public class DescuentoDecorator : Decorator
    {
        public DescuentoDecorator(Producto producto) : base(producto)
        {
            this.producto.Precio -= 10;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("El descuento fue de 10 pesos.");
        }
    }
}
