using System;

namespace Sum_Of_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number of seconds: ");
            var sec1 = int.Parse(Console.ReadLine());
            Console.Write("Insert second number of seconds: ");
            var sec2 = int.Parse(Console.ReadLine());
            Console.Write("Insert thirth number of seconds: ");
            var sec3 = int.Parse(Console.ReadLine());
            var sum = sec1 + sec2 + sec3;
            if (sum >= 120)
            {
                var sum2 = sum - 120;
                if (sum2 < 10)
                    Console.WriteLine("2:0" + sum2);
                else
                    Console.WriteLine("2:" + sum2);
            }
            else if (sum >= 60)
            {
                var sum3 = sum - 60;
                if (sum3 < 10)
                    Console.WriteLine("1:0" + sum3);
                else
                    Console.WriteLine("1:" + sum3);
            }
            else if (sum < 60)
            {
                if (sum < 10)
                    Console.WriteLine("0:0" + sum);
                else
                    Console.WriteLine("0:" + sum);
            }

        }
    }
}
