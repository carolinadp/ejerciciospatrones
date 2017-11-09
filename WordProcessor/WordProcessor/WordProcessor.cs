using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    public class WordProcessor
    {
        private Stack<Command> commands = new Stack<Command>();

        Word word = new Word();

        public void Write(char letter)
        {
            Command command = new WordProcessorCommand(this.word, 1, letter);
            command.Execute();
            this.commands.Push(command);
        }

        public void Erase()
        {
            Command command = new WordProcessorCommand(this.word, 2, (char)0);
            command.Execute();
            commands.Push(command);
        }

        public void CtrlZ()
        {
            Command command = this.commands.Peek();
            if (command != null)
            {
                command.Undo();
                this.commands.Pop();
            }
        }
    }
}
