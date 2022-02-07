using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a: ");
            var b1 = double.Parse(Console.ReadLine());
            Console.Write("Insert a1: ");
            var b2 = double.Parse(Console.ReadLine());
            Console.Write("Insert h: ");
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2;
            Console.WriteLine("The area is:  " + area + ".");

        }
    }
}
