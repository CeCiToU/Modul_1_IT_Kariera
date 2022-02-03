using System;

namespace Long_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Distance(km) = ");
            var km = double.Parse(Console.ReadLine());
            Console.Write("Day/Night: ");
            var time = Console.ReadLine().ToLower();
            if (time == "day")
            {
                if (km < 20)
                {
                    double price =Math.Round(( (km * 0.79 + 0.70) * 1.96), 2);

                    Console.WriteLine("It will cost {0} BGN.", price);
                }
                else if (km >= 20 && km < 100)
                {
                    double price = Math.Round((km * 0.09 * 1.96), 2);
                    Console.WriteLine("It will cost {0} BGN.", price);
                }
                else if (km >= 100)
                {
                    double price =Math.Round(( km * 0.06 * 1.96), 2);
                    Console.WriteLine("It will cost {0} BGN.", price);
                }
            }
            else if (time == "night")
            {
                if (km < 20)
                {
                    double price =Math.Round(( (km * 0.90 + 0.70) * 1.06), 2);
                    Console.WriteLine("It will cost {0} BGN.", price );
                }
                else if (km >= 20 && km < 100)
                {
                    double price = Math.Round((km * 0.09 * 1.96), 2);
                    Console.WriteLine("It will cost {0} BGN.", price);
                }
                else if (km >= 100)
                {
                    double price =Math.Round(( km * 0.06 * 1.96), 2);
                    Console.WriteLine("It will cost {0} BGN.", price);
                }

            }

        }
    }
}
