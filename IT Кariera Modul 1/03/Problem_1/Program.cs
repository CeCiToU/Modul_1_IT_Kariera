using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("Cantimeters =  ");
            Console.WriteLine(centimeters);


        }
    }
}
