using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program that builds a menu and a list for users to store contacts
            //List to store contacts
            List<string> contacts = new List<string>();
            while

                (true)
            {
                //Menu
                Console.WriteLine("Welcome to the Contact List Program!");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Remove a contact");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search for a contact");
            Console.WriteLine("5. Exit");
            int userChoice = int.Parse(Console.ReadLine());
            int choice = 0;

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the contact you would like to add: ");
                        string contact = Console.ReadLine();
                        contacts.Add(contact);
                        Console.WriteLine("Contact added!");
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the contact you would like to remove: ");
                        string contactRemove = Console.ReadLine();
                        contacts.Remove(contactRemove);
                        Console.WriteLine("Contact removed!");
                        break;
                    case 3:
                        Console.WriteLine("Here are all the contacts: ");
                        foreach (string c in contacts)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the name of the contact you would like to search for: ");
                        string contactSearch = Console.ReadLine();
                        if (contacts.Contains(contactSearch))
                        {
                            Console.WriteLine("Contact found!");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
