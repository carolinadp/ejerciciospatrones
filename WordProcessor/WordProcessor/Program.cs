using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            WordProcessor wp = new WordProcessor();
            char key = (char)Console.ReadKey().KeyChar;
            while (key != '$')
            {
                if (key == 'Z')
                {
                    wp.CtrlZ();
                }
                else if(key == '\b')
                {
                    wp.Erase();
                }
                else
                {
                    wp.Write(key);
                }
                key = (char)Console.ReadKey().KeyChar;
            }
        }
    }
}
