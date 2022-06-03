using System;

namespace Sums_Of_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.Write("How many numbers will you sum - ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Insert number: ");
                var num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                sum += num1;
               
            }
            Console.WriteLine("Their sum is: {0}", sum);
        }
    }
}
