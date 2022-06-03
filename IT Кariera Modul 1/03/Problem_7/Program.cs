using System;

namespace BGN_To_USD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert BGN balance to convert: ");
            var BGN = double.Parse(Console.ReadLine());
            var USD = BGN * 1.79549;
            double USD1 = Math.Round(USD, 2);
            Console.WriteLine("You have " + USD1 + " USD");

        }
    }
}
