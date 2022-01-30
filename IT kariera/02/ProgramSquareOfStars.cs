using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            if (n >= 2 && n <= 100)
            {
                string b = "*";
                Console.Write(b);
                for (i = 0; i < n - 2; i++)
                {
                    string c = " ";
                    Console.Write(c);
                }
                Console.WriteLine("b");
                
            }


        }
    }
}

