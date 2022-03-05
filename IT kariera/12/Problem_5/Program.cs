using System;

namespace ConsoleApp127
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else if (n >= 2)
            {
               while (n - 1 != 0)
               {
                    int number = f0;
                    f0 = f1;
                    f1 = f1 + number;
                    n--;
               }
                Console.WriteLine(f1);
            }
        }
    }
}
