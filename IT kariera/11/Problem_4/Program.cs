using System;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            for(int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 4;
            }
        }
    }
}
