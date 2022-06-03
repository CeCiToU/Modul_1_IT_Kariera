using System;

namespace Rad_To_Deg
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insert radian = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine("Degrees = " + Math.Round(deg, 0));


        }
    }
}
