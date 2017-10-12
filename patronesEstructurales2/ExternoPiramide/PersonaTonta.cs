using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternoPiramide
{
    public class PersonaTonta
    {
        public PersonaTonta Superior { get; set; }
        public string Nombre { get; set; }
        public int Inversion { get; set; }

        public PersonaTonta AgregarPersona(string nombre, int inversion)
        {
            PersonaTonta persona = new PersonaTonta();
            persona.Nombre = nombre;
            persona.Inversion = inversion;
            persona.Superior = this;
            return persona;
        }

    }
}
