using System;

namespace Outside_Or_Inside
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("X1 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y1 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("X2 = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y2 = ");
            double y = double.Parse(Console.ReadLine());
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("The point is inside");
            }
            else if (y >= y1 || y <= y2 || x <= x1 || x1 >= x2)
            {
                Console.WriteLine("The point is outside");
            }

        }
    }
}
