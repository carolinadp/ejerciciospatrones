using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorTexto
{
    class LetraFactory : IFlyWeight
    {
        private Dictionary<char, Letra> dic;

        public LetraFactory()
        {
            dic = new Dictionary<char, Letra>();
            dic.Add('a', new LetraA());
            dic.Add('b', new LetraB());
            dic.Add('c', new LetraC());
            dic.Add('d', new LetraD());
            dic.Add('e', new LetraE());

        }

        public Letra GetLetra(char letra)
        {
            Letra result = null;
            switch (letra)
            {
                case 'a':
                    result = dic['a'];
                    break;
                case 'b':
                    result = dic['b'];
                    break;
                case 'c':
                    result = dic['c'];
                    break;
                case 'd':
                    result = dic['d'];
                    break;
                case 'e':
                    result = dic['e'];
                    break;
            }
            return result;
        }
    }
}
