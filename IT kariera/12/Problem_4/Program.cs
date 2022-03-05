using System;

namespace ConsoleApp124
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The number entered: " + n);
                        break;

                    }
                    Console.WriteLine("The number is not even!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number");
                }
                

            }
           
        }
    }
}
