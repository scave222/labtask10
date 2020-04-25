using System;
using System.Collections.Generic;
using System.Linq;
namespace CarInventoryAPP
{
    public class Tokunbor
    { 
        public string Make{get; set;}
        public string Model{get; set;}
        public int Year{get; set;}
        public decimal Price{get; set;}

        public Tokunbor(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            
        }
        
        public override string ToString()
        {
            return $"==================================\nMake: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {Price:C}\n";
        }
        

        // public void Catalog()
        // {
        //     Console.Write("Enter car make: ");
        //     make = Console.ReadLine();

        //     Console.Write("Enter car model: ");
        //     model = Console.ReadLine();

        //     Console.Write("Enter car year: ");
        //     year = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Enter car price: ");
        //     price = Convert.ToDecimal(Console.ReadLine());

        //     totalinventory += price;

            
        //    result = $"==================================\nMake: {make}\nModel: {model}\nYear: {year}\nPrice: {price:C}\n";
        //     list.Add(result);
        // }


        // public void Lists()
        // {
        //     foreach (var item in list)
        //     {
        //         if(list == null)
        //         {
        //             Console.Write("There are currently no cars in the catalog.");
        //         }else
        //         Console.Write(item);
        //     }
        //     Console.Write($"Total Inventory: {totalinventory:C}");
        // }
        
        
        
    
    }
}