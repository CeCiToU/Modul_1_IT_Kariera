using System;

namespace Triangel_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Insert h: ");
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));

        }
    }
}
