using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    abstract class Element
    {
        protected Mediator mediator;

        public Element(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void ReceiveMessage(string message);
    }
}
