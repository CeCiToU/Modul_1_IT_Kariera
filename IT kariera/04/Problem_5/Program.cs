using System;

namespace Money_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert balance to convert: ");

            var num = double.Parse(Console.ReadLine());
            Console.Write("Insert currency 1: ");
            var first = Console.ReadLine().ToUpper();
            Console.Write("Insert currency 2: ");
            var second = Console.ReadLine().ToUpper();

            if (first == "USD")
            {
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.7955, 2) + " BGN");
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.91799, 2) + " EUR");
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.34138, 2) + " GBP");
                }

            }
            if (first == "BGN")
            {
                if (second == "USD")
                {
                    Console.WriteLine(Math.Round(num / 1.70940, 2) + " USD");
                }
                else if (second == "EUR")
                {
                    Console.WriteLine(Math.Round(num / 1.95503, 2) + " EUR");
                }
                else if (second == "GBP")
                {
                    Console.WriteLine(Math.Round(num / 2.29357, 2) + " GBP");
                }

            }
            if (first == "EUR")
            {
                if (second == "BGN")
                {
                    Console.WriteLine(Math.Round(num * 0.51098, 2) + " BGN");
                }
                else if (second == "USD")
                {
                    Console.WriteLine(Math.Round(num * 0.87336, 2) + " USD");
                }
                else if (second == "GBP")
                {
                    Console.WriteLine(Math.Round(num * 0.77165, 2) + " GBP");
                }
            }
            if (first == "GBP")
            {
                if (second == "BGN")
                {
                    Console.WriteLine(Math.Round(num * 0.43620, 2) + " BGN");
                }
                else if (second == "USD")
                {
                    Console.WriteLine(Math.Round(num * 0.74543, 2) + " USD");
                }
                else if (second == "EUR")
                {
                    Console.WriteLine(Math.Round(num * 0.85287, 2) + " EUR");
                }

            }
        }
    }
}