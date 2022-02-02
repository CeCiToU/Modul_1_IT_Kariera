using System;

namespace ConsoleApp51
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
                for (int e = 1; e < n; e++)
                {
                    b += "*";
                }
                Console.WriteLine(b);
                string c = "";
                for (int f = 2; f < n; f++)
                {
                    c += " ";
                }
                string b1 = "*";
                string result = "";
                for (int a = 2; a < n; a++)
                {
                    result = string.Concat(b1, c, b1);
                    Console.WriteLine(result);
                }
                Console.WriteLine(b);
            }
            else Console.WriteLine("Невалидна стойност на n");
        }

    }
}

