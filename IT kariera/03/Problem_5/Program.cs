using System;

namespace Celsius_To_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert celsius:");
            double celsius = double.Parse(Console.ReadLine());

            var fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(celsius + " degrees on celsius equals: " + fahrenheit + " degrees on fahrenheit.");

        }
    }
}
