using System;

namespace Outside_Inside_Or_Border
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
            var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            var onDownSide = (y == y2) && (x >= x1) && (x <= x2);

            if (onLeftSide || onRightSide || onDownSide || onUpSide)
            {
                Console.WriteLine("On the border");
            }
            else
            {
            
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
