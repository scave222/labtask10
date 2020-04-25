using System;
using System.Collections.Generic;

namespace CarInventoryAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Tokunbor> list = new List<Tokunbor>();

       

            Console.WriteLine("Welcome to Caleb Okogbe's Cool “Tokunbo” Autos!");
            Console.Write("Enter command add,list or quit: ");
            string command = Console.ReadLine();
            
            if(command == "add")
                {   
               
                while(command == "add")
                {
                    Catalog();
                }
                if(command == "list")
                {
                    Lists();
                }
            }
            else if(command == "list")
                {
                        Console.Write("There are currently no cars in the catalog.");
                }
            else if(command == "quit")
                {
                    Console.Write("Good bye!");
                    
                }

            
            else if(command != "add" || command != "list" || command != "quit")
                {   
                    Console.WriteLine($"Sorry, but {command} is not a valid command. Please try again.");
                }

            void Catalog()
            {
                
                
                Console.Write("Enter car make: ");
                string Make = Console.ReadLine();

                Console.Write("Enter car model: ");
                string Model = Console.ReadLine();

                Console.Write("Enter car year: ");
                int Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter car price: ");
                decimal Price = Convert.ToDecimal(Console.ReadLine());

               

                Tokunbor tokunbor = new Tokunbor(Make, Model, Year, Price);

                
                
                list.Add(tokunbor);
            
                Console.Write("Enter command add,list or quit: ");
                command = Console.ReadLine();
            }

            void Lists()
            {
                decimal totalinventory = 0;
                int count = 0;
                foreach (var item in list)
            {   
                count++;
                totalinventory += item.Price;
                Console.Write(item);
            }
            Console.Write($"=====================\nTotal Cars available: {count}\nTotal Inventory: {totalinventory:C}");
            }

        }
    }
}
