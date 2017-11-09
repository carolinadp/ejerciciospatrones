using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class Mediator
    {
        private Dictionary<int, Element> elements = new Dictionary<int, Element>();
        public void Register(int id, Element element)
        {
            this.elements.Add(id, element);
        }

        public void SendMessage(int id, string message)
        {
            Element receptor = null;
            if (this.elements.TryGetValue(id, out receptor))
            {
                receptor.ReceiveMessage(message);
            }
        }
    }
}
