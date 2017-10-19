using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External
{
    public class ValidadorPeso
    {
        public bool ValidarPeso(int kg)
        {
            if (kg > 4 && kg < 20)
            {
                return true;
            }
            return false;
        }
    }
}
