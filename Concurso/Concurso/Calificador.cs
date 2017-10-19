using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using External;

namespace Concurso
{
    class Calificador : IFacade
    {
        private CalificadorInteligencia inteligencia = null;
        private ValidadorBelleza belleza = null;
        private ValidadorPeso peso = null;
        public Calificador()
        {
            inteligencia = new CalificadorInteligencia();
            belleza = new ValidadorBelleza();
            peso = new ValidadorPeso();
        }
        public int ObtenerCalificacion(Perro perro)
        {
            int calificacion = 0;
            if (inteligencia.EsInteligente(new List<int>(perro.Calificaciones))){
                calificacion++;
            }
            if (belleza.EsBonito(perro.Belleza))
            {
                calificacion++;
            }
            if (peso.ValidarPeso(perro.Peso))
            {
                calificacion++;
            }

            Console.WriteLine(string.Format("{0} saco {1} puntos", perro.Nombre, calificacion));

            return calificacion;
        }
        
    }
}
