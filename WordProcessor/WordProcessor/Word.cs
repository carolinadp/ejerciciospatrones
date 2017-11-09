using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    public class Word
    {
        private int cursor = 0;

        private char[] letters = new char[100];

        public void AddLetter(char letter)
        {
            this.letters[cursor] = letter;
            cursor++;
            this.Display();
        }

        public char Erase()
        {
            char erased = (char)0;
            if (cursor > 0)
            {
                cursor--;
                erased = this.letters[cursor];
                this.letters[cursor] = (char)0;
            }

            this.Display();

            return erased;
        }

        private void Display()
        {
            Console.WriteLine();
            for (int i=0;i<cursor; i++)
            {
                Console.Write(this.letters[i]);
            }
            Console.WriteLine();
        }

    }
}
