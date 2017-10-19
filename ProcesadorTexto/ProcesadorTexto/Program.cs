using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            LetraFactory factory = new LetraFactory();
            string texto = "abbabbnacdendeabcde";
            bool negritas = false;
            int posicion = 0;
            foreach (char car in texto.ToCharArray())
            {
                posicion++;
                if (car == 'n')
                {
                    negritas = !negritas;
                } else
                {
                    Letra letra = factory.GetLetra(car);
                    letra.Mostrar(posicion, negritas);
                }
            }
            Console.Read();
        }

    }
}
