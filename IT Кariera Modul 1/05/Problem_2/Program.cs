using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            double num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number " + num + " is even!");
            }
            else
            {
                Console.WriteLine("The number " + num + " is odd!");
            }
        }
    }
}
