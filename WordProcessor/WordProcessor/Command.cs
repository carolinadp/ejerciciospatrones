using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    public abstract class Command
    {
        protected int action = 0;

        protected char letter = (char) 0;

        public Command (int action, char letter)
        {
            this.action = action;
            this.letter = letter;
        }

        public abstract void Execute();

        public abstract void Undo();

    }
}
