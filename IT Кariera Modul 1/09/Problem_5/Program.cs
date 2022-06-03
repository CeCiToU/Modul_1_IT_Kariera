using System;

namespace Max_Number_From_Many
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;
            a = b; b = a;
            a++; b--;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
