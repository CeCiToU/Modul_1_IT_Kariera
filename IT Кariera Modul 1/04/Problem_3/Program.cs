using System;

namespace Rectangle_Area_With_Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert x1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Insert y1: ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Insert x2: ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Insert y2: ");
            var y2 = double.Parse(Console.ReadLine());
            
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = width * height;
            Console.WriteLine("The area is: " + area);
            var perimeter = height * 2 + width * 2;
            Console.WriteLine("The perimeter is: " + perimeter);
            }
           

        }
    }
}
