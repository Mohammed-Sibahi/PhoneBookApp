using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PhoneBookApp!");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 serach for contacts for a given name.")

            var userInput = Console.ReadLine();
            
            var phoneBook = new PhoneBookApp();

            switch (userInput)
            {
                case "1": 
                    break;
                     case "2": 
                    break;
                     case "3": 
                    break;
                     case "4": 
                    break;
                    default: 
                    Console.WriteLine("Select valid operation");
                    break;
            }
        }
    }
}
