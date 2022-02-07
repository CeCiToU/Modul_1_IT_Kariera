using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                int stars = 0;
                int spaces = n;
                for (int row = 0; row < n + 1; row++)
                {
                    for (int spaces1 = 0; spaces1 < spaces; spaces1++)
                    {
                        Console.Write(" ");
                    }
                    for (int stars1 = 0; stars1 < stars; stars1++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" | ");
                    for (int stars1 = 0; stars1 < stars; stars1++)
                    {
                        Console.Write("*");
                    }
                    for (int spaces1 = 0; spaces1 < spaces; spaces1++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    spaces--;
                    stars++;
                }
            }

        }
    }
}
