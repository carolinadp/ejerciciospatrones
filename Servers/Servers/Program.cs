using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Servers.Mediator();

            Server server1 = new Server(1, mediator);
            Server server2 = new Server(2, mediator);
            Server server3 = new Server(3, mediator);

            mediator.Register(1, server1);
            mediator.Register(2, server2);
            mediator.Register(3, server3);

            server1.SendMessage(2, "Start Apache");
            server3.SendMessage(1, "Check for viruses");
            server2.SendMessage(3, "Shut down");

            Console.ReadLine();

        }
    }
}
