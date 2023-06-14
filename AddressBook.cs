using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Contact> contactList = new List<Contact>();
        public void addContact()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter phone");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();
            Contact contact = new Contact(name,email,phone,state,city,zip);
            contactList.Add(contact);
            Console.WriteLine("Contact added..");
        }

        public void Display()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        public void delete()
        {
            Console.WriteLine("Enter name of the contact: ");
            string input = Console.ReadLine();
            for(int i=0;i<contactList.Count;i++)
            {
                Contact contact = contactList[i];
                if(input==contact.name)
                {
                    contactList.Remove(contact);
                }
            }
            Console.WriteLine("Contact deleted ....");
        }
    }
}
