using System;

namespace Random_Shape_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose shape: ");
            string type = Console.ReadLine();
            if (type == "square")
            {
                Console.Write("Choose side size: ");
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine("The area is: " + Math.Round(area, 2));
            }
            else if (type == "rectangle")
            {
                Console.Write("Choos size for side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Choose size for side b: ");
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine("The area is: " + Math.Round(area, 2));
            }
            else if (type == "circle")
            {
                Console.Write("Choose radius size: ");
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine("The area is: " + Math.Round(area, 2));
            }
            else if (type == "triangle")
            {
                Console.Write("Choose side size: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Choose height size: ");
                double h = double.Parse(Console.ReadLine());
                double area = (a * h) / 2;
                Console.WriteLine("The area is: " + Math.Round(area, 2));

            }

        }
    }
}
