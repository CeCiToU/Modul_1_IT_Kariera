
using System;

namespace Square_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int stars = 0; stars < n; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
