
using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers will you look at - ");
            int numbersCount = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;
            for (int i = 0; i < numbersCount ; i++)
            {
                Console.Write("Choose number: ");
                int currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (currentNumber < minNumber )
                {
                    minNumber = currentNumber;
                }

            }
            Console.WriteLine("Min number is : {0}",minNumber);
        }
    }
}
