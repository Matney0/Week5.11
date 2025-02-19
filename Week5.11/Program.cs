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
                //Loops through menu as long the user doesnt wish to exit 
                //User options
                Console.WriteLine("Welcome to the Contact List Program!");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Remove a contact");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search for a contact");
            Console.WriteLine("5. Exit");
            int userChoice = int.Parse(Console.ReadLine());
            int choice = 0;

                //Used a switch clause to run through the multiple different program actions
                switch (userChoice)
                {
                    //Didnt add any methods as this program execution is mostly straightforward 
                    //Case to add a contact 
                    case 1:
                        Console.WriteLine("Enter the name of the contact you would like to add: ");
                        string contact = Console.ReadLine();
                        contacts.Add(contact);
                        Console.WriteLine("Contact added!");
                        //Ends case proccesing 
                        break;
                    case 2:
                        //A case that removes a contact 
                        Console.WriteLine("Enter the name of the contact you would like to remove: ");
                        string contactRemove = Console.ReadLine();
                        contacts.Remove(contactRemove);
                        Console.WriteLine("Contact removed!");
                        //Ends case proccesing
                        break;
                    case 3:
                        //Lists the contacts that were added and stored
                        Console.WriteLine("Here are all the contacts: ");
                        foreach (string c in contacts)
                        {
                            Console.WriteLine(c);
                        }
                        //Ends case proccesing
                        break;
                    case 4:
                        //Searching contact list
                        Console.WriteLine("Enter the name of the contact you would like to search for: ");
                        string contactSearch = Console.ReadLine();
                        if (contacts.Contains(contactSearch))
                        {
                            //if a contact is avaliable/added
                            Console.WriteLine("Contact found!");
                        }
                        else
                        {
                            //entered contact not added to the list 
                            Console.WriteLine("Contact not found!");
                        }
                        //Ends case proccesing
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        //Exits from the system only when the user input is 5
                        Environment.Exit(0);
                        //Ends case proccesing
                        break;
                    default:
                        //No valid options input from the user 
                        Console.WriteLine("Invalid choice. Please try again.");
                        //Ends case proccesing
                        break;
                }
            }
        }
    }
}
