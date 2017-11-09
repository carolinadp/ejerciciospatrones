using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string GetDescriuption()
        {
            return string.Format("{0} {1} que tiene {2} años, su numero es {3}", this.Name, this.LastName, this.Age, this.PhoneNumber);
        }
        public Memento SaveMemento()
        {
            return new Memento(this.Name, this.LastName, this.PhoneNumber, this.Age);
        }
        public void GoToMemento(Memento memento)
        {
            this.Name = memento.Name;
            this.LastName = memento.LastName;
            this.PhoneNumber = memento.PhoneNumber;
            this.Age = memento.Age;
        }

    }
}
