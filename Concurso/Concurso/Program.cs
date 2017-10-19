using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Calificador calificador = new Calificador();

            Perro firulais = new Perro
            {
                Belleza = 1,
                Nombre = "Firulais",
                Calificaciones = new int[] { 5, 7, 10 },
                Peso = 15,
                Raza = "Corriente"
            };

            calificador.ObtenerCalificacion(firulais);

            Perro scooby = new Perro
            {
                Belleza = 7,
                Nombre = "Scooby",
                Calificaciones = new int[] { 5, 6, 10, 2 },
                Peso = 10,
                Raza = "Pastor Alemán"
            };
            calificador.ObtenerCalificacion(scooby);

            Perro frida = new Perro
            {
                Belleza = 8,
                Nombre = "Frida",
                Calificaciones = new int[] { 6, 9, 8, 7 },
                Peso = 9,
                Raza = "Labrador"
            };
            calificador.ObtenerCalificacion(frida);

            Perro snoopy = new Perro
            {
                Belleza = 7,
                Nombre = "Snoopy",
                Calificaciones = new int[] { 9, 8, 9, 10 },
                Peso = 6,
                Raza = "Beagle"
            };
            calificador.ObtenerCalificacion(snoopy);

            Console.Read();
        }
    }
}
