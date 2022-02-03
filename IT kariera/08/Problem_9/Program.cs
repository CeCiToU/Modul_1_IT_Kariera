using System;

namespace Monthly_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose month (May - October): ");
            string month = Console.ReadLine().ToLower();
            if (month == "may" || month == "june" || month == "july" || month == "august" || month == "september " || month == "october")
            {
                Console.Write("Number of nights [0 - 200]: ");
                int night = int.Parse(Console.ReadLine());
                if (night >= 0 && night <= 200)
                {
                    if (month == "may" || month == "october")
                    {
                        if (night <= 7)
                        {
                            var pricest = 50 * night;
                            var priceht = 65 * night;
                            Console.WriteLine("Apartament: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);

                        }
                        else if (night > 7 && night <= 14)
                        {
                            var price = 50 - 50 * 0.05;
                            var pricest = night * price;
                            var priceht = 65 * night;
                            Console.WriteLine("Apartament: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);
                        }
                        else if (night > 14)
                        {
                            var price = 50 - 50 * 0.3;
                            var pricest = night * price;
                            var price2 = 65 - 65 * 0.1;
                            var priceht = night * price2;
                            Console.WriteLine("Apartamen: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);
                        }
                    }
                    else if (month == "june" || month == "september")
                    {
                        if (night <= 14)
                        {
                            var pricest = 75.20 * night;
                            var priceht = Math.Round(68.70 * night, 2);
                            Console.WriteLine("Apartament: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);

                        }

                        else if (night > 14)
                        {
                            var price = 50 - 50 * 0.2;
                            var pricest = night * price;
                            var price2 = 65 - 65 * 0.1;
                            var priceht = night * price2;
                            Console.WriteLine("Apartamen: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);
                        }
                    }
                    if (month == "july" || month == "august")
                    {

                        if (night <= 7)
                        {
                            var pricest = 76 * night;
                            var priceht = 77 * night;
                            Console.WriteLine("Apartament: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);
                        }
                        else if (night > 14)
                        {
                            var pricest = 76 * night;
                            var price = 76 - 76 * 01;
                            var priceht = night * price;
                            Console.WriteLine("Apartament: {0} lv.", priceht);
                            Console.WriteLine("Studio: {0} lv.", pricest);
                        }
                    }
                }
            }

        }
    }
}
