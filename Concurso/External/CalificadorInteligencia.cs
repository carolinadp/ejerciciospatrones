using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External
{
    public class CalificadorInteligencia
    {
        public bool EsInteligente(List<int> califs)
        {
            if (califs.Average() > 7)
            {
                return true;
            }

            return false;

        }
    }
}
