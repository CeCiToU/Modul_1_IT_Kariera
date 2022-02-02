using System;

namespace Prize_By_City
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose type: ");
            string type = Console.ReadLine().ToLower();
            Console.Write("Choose your city: ");
            string city = Console.ReadLine().ToLower();
            Console.Write("Choose quantity: ");
            double quantity = double.Parse(Console.ReadLine().ToLower());

            if (city == "sofia")
            {
                if (type == "coffee")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (type == "water")
                {

                    Console.WriteLine(0.80 * quantity);
                }
                else if (type == "beer")
                {

                    Console.WriteLine(1.20 * quantity);
                }
                else if (type == "sweets")
                {

                    Console.WriteLine(1.45 * quantity);
                }
                else if (type == "peanuts")
                {

                    Console.WriteLine(1.60 * quantity);
                }
            }
            else if (city == "plovdiv")
            {
                if (type == "coffee")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (type == "water")
                {

                    Console.WriteLine(0.70 * quantity);
                }
                else if (type == "beer")
                {

                    Console.WriteLine(1.15 * quantity);
                }
                else if (type == "sweets")
                {

                    Console.WriteLine(1.30 * quantity);
                }
                else if (type == "peanuts")
                {

                    Console.WriteLine(1.50 * quantity);
                }
            }
            else if (city == "varna")
            {
                if (type == "coffee")
                {

                    Console.WriteLine(0.45 * quantity);
                }
                else if (type == "water")
                {

                    Console.WriteLine(0.70 * quantity);
                }
                else if (type == "beer")
                {

                    Console.WriteLine(1.10 * quantity);
                }
                else if (type == "sweets")
                {

                    Console.WriteLine(1.35 * quantity);
                }
                else if (type == "peanuts")
                {

                    Console.WriteLine(1.55 * quantity);
                }
            }

        }
    }
}
