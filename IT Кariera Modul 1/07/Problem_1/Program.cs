using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your age: ");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Your gender (m/f): ");
            string gender = Console.ReadLine();
            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Hi, Master!");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Hi, Mr.!");
                }
            }
            else if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Hi, Miss!");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Hi, Ms.!");
                }
            }

        }
    }
}
