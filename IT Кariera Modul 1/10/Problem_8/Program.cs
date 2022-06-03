using System;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n >= 3 && n <= 100)
            {
                string firstAndLastRow = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
                Console.WriteLine(firstAndLastRow);
                for (int i = 0; i < n - 2; i++)
                {
                    string middleRowLeft = new string('*', 1) + new string('/', n * 2 - 2) + new string('*', 1);
                    double del = n / 2;
                    string middleRowRight = new string('*', 1) + new string('/', n * 2 - 2) + new string('*', 1);
                    if (n % 2 == 0)
                    {
                        if (i == Math.Round(del - 2))
                        {
                             var space = new string('|', n);
                             Console.WriteLine(middleRowLeft + space + middleRowRight);
                        }
                       else
                       {
                             Console.WriteLine(middleRowLeft + new string(' ', n) + middleRowRight);
                       }
                    }
                    else if (n % 2 == 1 )
                    {
                        if (i == Math.Round(del - 1))
                        {
                            var space = new string('|', n);
                            Console.WriteLine(middleRowLeft + space + middleRowRight);
                        }
                        else
                        {
                            Console.WriteLine(middleRowLeft + new string(' ', n) + middleRowRight);
                        }
                    }
                   

                }
                      Console.WriteLine(firstAndLastRow);


            }

        }
    }
}
