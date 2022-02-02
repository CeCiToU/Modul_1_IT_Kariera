using System;

namespace Same_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number: ");
            
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("Insert second number: ");
            var num2 = double.Parse(Console.ReadLine());
            if ( num1 == num2)
            {
                Console.Write("Insert thirth number: ");
                var num3 = double.Parse(Console.ReadLine());
               if (num2 == num3)
                {
                    Console.WriteLine("They are the same numbers!");
                }
               else
                {
                    Console.WriteLine("They are not the same!");
                }
            }
            else
            {
                Console.WriteLine("They are not the same!");
            }
        }
    }
}
