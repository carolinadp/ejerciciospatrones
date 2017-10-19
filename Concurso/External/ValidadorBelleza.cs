using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External
{
    public class ValidadorBelleza
    {
        public bool EsBonito(int belleza)
        {
            if (belleza > 5)
            {
                return true;
            }
            return false;
        }
    }
}
