using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose number [1/7]: ");
            int day = int.Parse(Console.ReadLine());
            if (day == 1)
            {
                Console.WriteLine("The day is Monday");
            }
            else if (day == 2 )
            {
                Console.WriteLine("The day is Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("The day is Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("The day is Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("The day is Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("The day is Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("The day is Sunday");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

    }
}
