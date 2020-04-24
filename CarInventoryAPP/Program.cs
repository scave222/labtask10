using System;
using System.Collections.Generic;

namespace CarInventoryAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tokunbor tokunbor = new Tokunbor();

            
            

            Console.WriteLine("Welcome to Caleb Okogbe's Cool “Tokunbo” Autos!");

            while(true)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine();

                if(command == "add")
                {
                    tokunbor.Catalog();
                    
                }
                if(command == "list")
                {
                        tokunbor.Lists();
                        break;
                    
                }
                if(command == "quit")
                {
                    Console.Write("Good bye!");
                        break;
                    
                }
                if(command == "show")
                {   
                    Console.WriteLine($"Sorry, but {command} is not a valid command. Please try again.");
                }
            }

            

        }
    }
}
