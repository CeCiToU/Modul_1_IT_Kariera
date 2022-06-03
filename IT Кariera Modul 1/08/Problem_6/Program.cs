using System;

namespace Holiday_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your budget [10 - 5000]: ");
            var money = double.Parse(Console.ReadLine());
            if (money <= 5000.00 && money >= 10.00)
            {
                Console.Write("Choose season (Summer/Winter): ");
                var season = Console.ReadLine().ToLower();
                if (season == "summer" || season == "winter")
                {
                    if (money <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        if (season == "summer")
                        {
                            var perc = Math.Round(money * 0.30, 2);
                            Console.WriteLine("Camp - " + perc);
                        }
                        else if (season == "winter")
                        {
                            double perc = Math.Round(money * 0.70, 2);
                            Console.WriteLine("Hotel - " + perc);
                        }
                    }
                    else if (money > 100 && money <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        if (season == "summer")
                        {
                            var perc = Math.Round(money * 0.40, 2);
                            Console.WriteLine("Camp - " + perc);
                        }
                        else if (season == "winter")
                        {
                            var perc = Math.Round(money * 0.80, 2);
                            Console.WriteLine("Hotel - " + perc);
                        }
                    }
                    else if (money > 1000 && money <= 5000)
                    {
                        Console.WriteLine("Somewhere in Europe");
                        if (season == "summer")
                        {
                            var perc = Math.Round(money * 0.90, 2);
                            Console.WriteLine("Hotel - " + perc);
                        }
                        else if (season == "winter ")
                        {
                            var perc = Math.Round(money * 0.90, 2);
                            Console.WriteLine("Hotel - " + perc);
                        }
                    }
                }
                else
                {
                    Console.Write("Invalid");
                }
            }
            else
            {
                Console.Write("Invalid");
            }


        }
    }
}
