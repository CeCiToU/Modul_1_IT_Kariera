using System;

namespace Kino_Price
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            Console.Write("Type of projection: ");
            var TypeOfProjection = Console.ReadLine().ToLower();
            Console.Write("Row seat number: ");
            var row = int.Parse(Console.ReadLine());
            Console.Write("Column seat number: ");
            var column = int.Parse(Console.ReadLine());
            if (TypeOfProjection == "premiere")
            {
                double premiere = 12.00;
                double price = row * column * premiere;
                Console.WriteLine(Math.Round(price,2) + " leva is your ticket's price");
            }
            else if (TypeOfProjection == "normal")
            {
                double normal = 7.50;
                double price = row * column * normal;
                Console.WriteLine(Math.Round(price, 2) + " leva is your ticket's price.");
            }
            else if (TypeOfProjection == "discount")
            {
                double discount = 5.00;
                double price = Math.Round(row * column * discount, 2);
                Console.WriteLine(price + ".00 leva is your ticket's price.");
            }

        }
    }
}
