using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact
            {
                Name = "Miguel Angel",
                LastName = "Gaytan Uribe",
                Age = 70,
                PhoneNumber = "56630661333"
            };

            Console.WriteLine(contact.GetDescriuption());
            MementoStore store = new MementoStore();
            store.Memento = contact.SaveMemento();

            contact.LastName = "Quiroz";
            contact.Age = 21;
            contact.PhoneNumber = "4492345671";

            Console.WriteLine(contact.GetDescriuption());

            contact.GoToMemento(store.Memento);

            Console.WriteLine(contact.GetDescriuption());

            Console.ReadKey();
        }
    }
}
