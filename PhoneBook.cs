﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);            
            }
        }

       public void DisplayAllContact()
        {
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }
    }
}
