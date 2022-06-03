using System;

namespace Play_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Days = ");
            var day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 365)
            {


                var Rest = 127 * day;
                var AtWork = (365 - day) * 63;
                var SumOfPlayTime = AtWork + Rest;
                if (30000 > SumOfPlayTime)
                {
                    var hours = (30000 - SumOfPlayTime) / 60;
                    var min = (30000 - SumOfPlayTime) % 60;
                    Console.WriteLine("Tom sleeps well!");
                    Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
                }
                else if (30000 < SumOfPlayTime)
                {
                    var hours = Math.Abs(30000 - SumOfPlayTime) / 60;
                    var min = Math.Abs(30000 - SumOfPlayTime) % 60;
                    Console.WriteLine("Tom will run  away!");
                    Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
