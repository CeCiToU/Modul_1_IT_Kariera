using System;

namespace Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert mark: ");
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else if (mark <= 5.49)
            {
                Console.WriteLine("Not excellent.");
            }
            else
            {
                Console.WriteLine("No exit");
            }

        }
    }
}
