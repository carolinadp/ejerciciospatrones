using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    public class WordProcessorCommand : Command
    {
        private Word word = null;
        public WordProcessorCommand (Word word, int action, char letter) : base(action, letter)
        {
            this.word = word;
        }

        public override void Execute()
        {
            if (this.action == 1)
            {
                this.word.AddLetter(this.letter);
            }
            else if (this.action == 2)
            {
                this.letter = this.word.Erase();
            }
        }

        public override void Undo()
        {
            if (this.action == 1)
            {
                this.word.Erase();
            }
            else if (this.action == 2)
            {
                this.word.AddLetter(this.letter);
            }
        }
    }
}
