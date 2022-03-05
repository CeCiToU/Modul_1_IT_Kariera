using System;

namespace ConsoleApp128
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for ( int row = 1; row <= n; row++ )
            {
                for (int col = 1; col <= row;col++)
                {
                    
                        Console.Write(number);
                    Console.Write(" ");
                    
                    number++;
                    if (number > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number > n)
                {
                    break;
                }
            }
        }
    }
}
