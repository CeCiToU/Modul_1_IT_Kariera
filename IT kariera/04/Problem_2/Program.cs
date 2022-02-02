using System;

namespace Circle_Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert radius: ");
            var r = double.Parse(Console.ReadLine());
            var Perimeter = 2 * Math.PI * r;
            var Area = Math.PI * r * r;
            Console.Write("The area is: ");
            Console.WriteLine(Math.Round(Area, 2));
            Console.Write("The perimeter is: ");
            Console.WriteLine(Math.Round(Perimeter, 2));

        }
    }
}
