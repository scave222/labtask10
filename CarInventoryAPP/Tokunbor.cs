using System;
using System.Collections.Generic;
using System.Linq;
namespace CarInventoryAPP
{
    public class Tokunbor
    { 
        public string make;
        public string model;
        public int year;
        public decimal price;
        public string result;
        public decimal totalinventory;
        List<string> list = new List<string>() {};
        

        public void Catalog()
        {
            Console.Write("Enter car make: ");
            make = Console.ReadLine();

            Console.Write("Enter car model: ");
            model = Console.ReadLine();

            Console.Write("Enter car year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter car price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            totalinventory += price;

            
           result = $"==================================Make: {Convert.ToString(make)}\nModel: {Convert.ToString(model)}\nYear: {Convert.ToString(year)}\nPrice: {Convert.ToString(price)}\nTotal Inventory: {Convert.ToString(totalinventory)}\n========================================\n";
            list.Add(result);
        }


        public void Lists()
        {
            foreach (var item in list)
            {
                if(!list.Any())
                {
                    Console.Write("There are currently no cars in the catalog.");
                }else
                Console.Write(item);
            }
        }
        
        
        
    
    }
}