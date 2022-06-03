using System;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n ; i++)
            {
                Console.Write("$ ");
                for (int money = 0; money < i; money++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
