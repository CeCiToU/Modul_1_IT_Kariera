using System;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                { 
                    Console.Write(" ");
                }
                   
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                     Console.Write(" *");
                }
                  
                Console.WriteLine();
            }
            // it is not done, it need to be done the bottom part of it :(
        }
    }
}
