using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    internal class Contact
    {
        // adding a constructor, which is a member of a class
        // It's a method. We put the initialization code in 
        // the constructor. The name of the constructor is 
        // always the same to that of the class. 
        // Constructor can be public or private
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
