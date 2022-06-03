using System;

namespace Bigger_Or_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number: ");
           
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("Insert second number: ");
            var num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.Write("Bigger number is: ");
                Console.WriteLine(num1);
            }
            else if (num2 > num1)
            {
                Console.Write("Bigger number is: ");
                Console.WriteLine(num2);
            }
            else if (num1 == num2)
            {
                Console.Write("The numbers are equal!");
               
            }

        }
    }
}
