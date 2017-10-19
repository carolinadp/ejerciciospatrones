using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorTexto
{
    abstract class Letra
    {
        public char Caracter { get; protected set; }
        public int Posicion { get; private set; }
        public bool Negrita { get;private set; }

        public void Mostrar(int posicion, bool negrita)
        {
            this.Posicion = posicion;
            this.Negrita = negrita;
            if (this.Negrita)
            {
                Console.Write("*" + this.Caracter);
            }
            else
            {
                Console.Write(this.Caracter);
            }
        }
    }
}
