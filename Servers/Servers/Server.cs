using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class Server : Element
    {
        private int id;

        public Server(int id, Mediator mediator) : base(mediator)
        {
            this.id = id;
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Yo {0} Recibi mensaje: " + message, id);
        }

        public void SendMessage(int receiverId, string message)
        {
            Console.WriteLine();
            Console.WriteLine("Yo {0} enviando mensaje a {1}", this.id, receiverId);
            this.mediator.SendMessage(receiverId, message);
        }
    }
}
