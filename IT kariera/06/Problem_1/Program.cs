using System;

namespace Write_Numbers_1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type number: ");
            var num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Written number is one");
            }
            else if (num == 2)
            {
                Console.WriteLine("Written number is two");
            }
            else if (num == 3)
            {
                Console.WriteLine("Written number is three");
            }
            else if (num == 4)
            {
                Console.WriteLine("Written number is four");
            }
            else if (num == 5)
            {
                Console.WriteLine("Written number is five");
            }
            else if (num == 6)
            {
                Console.WriteLine("Written number is six");
            }
            else if (num == 7)
            {
                Console.WriteLine("Written number is seven");
            }
            else if (num == 8)
            {
                Console.WriteLine("Written number is eight");
            }
            else if (num == 9)
            {
                Console.WriteLine("Written number is nine");
            }
            else if (num >= 10)
            {
                Console.WriteLine("Written number is number too big");
            }

        }
    }
}
