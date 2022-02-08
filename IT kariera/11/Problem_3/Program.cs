using System;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(currentNum);
                currentNum = currentNum * 2;
                
            }
        }
    }
}
