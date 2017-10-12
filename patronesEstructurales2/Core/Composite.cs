using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternoPiramide;

namespace Core
{
    public class Composite
    {
        private PersonaTonta persona = null;
        private List<Composite> Hijos = new List<Composite>();

        public Composite(string nombre, int inversion)
        {
            this.persona = new PersonaTonta();
            this.persona.Nombre = nombre;
            this.persona.Inversion = inversion;
        }
        public Composite(PersonaTonta persona)
        {
            this.persona = persona;
        }
        public Composite Agregar(string nombre, int inversion)
        {
            Composite hijo = new Composite(this.persona.AgregarPersona(nombre, inversion));
            this.Hijos.Add(hijo);

            return hijo;
        }

        public void Mostrar()
        {
            Console.WriteLine(string.Format("{0} invirtio ${1:C}", this.persona.Nombre, this.persona.Inversion));

            foreach (Composite composite in this.Hijos)
            {
                composite.Mostrar();
            }
        }
    }
}
