using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyAssignment37
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", this.Name, this.Number);
        }
    }

    class PhoneBook : IEnumerable<Contact>
    {
        public List<Contact> contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
        };

        public IEnumerator<Contact> GetEnumerator()
        {
            return contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
