using System;

namespace plus15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hour = ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Minutes = ");
            int minute = int.Parse(Console.ReadLine());
            minute = minute + 15;
            if (minute > 59)
            {
                hour += 1;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);

            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }

        }
    }
}
