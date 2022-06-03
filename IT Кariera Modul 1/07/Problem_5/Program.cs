using System;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number = ");
            var num = double.Parse(Console.ReadLine());
            if (num >= 100 && num <= 200)
            {
                Console.WriteLine("The number is valid!");
            }
            else if (num == 0)
            {
                Console.WriteLine("The number is unknown!");
            }
            else
            {
                Console.WriteLine("The number is invalid!!!");
            }

        }
    }
}
