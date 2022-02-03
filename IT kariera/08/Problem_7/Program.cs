using System;

namespace Simple_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number one = ");
            var N1 = double.Parse(Console.ReadLine());
            if (N1 <= 40000 && N1 >= 0)
            {
                Console.Write("Number two = ");
                var N2 = double.Parse(Console.ReadLine());
                if (N2 <= 40000 && N2 >= 0)
                {
                    Console.Write("Choose symbol (+, -, *, /, %): ");
                    string symbol = Console.ReadLine();
                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/" || symbol == "%")
                    {
                        if (symbol == "+")
                        {
                            var res = N1 + N2;
                            var EvenOrOdd = res % 2;
                            if (EvenOrOdd == 0)
                            {
                                Console.WriteLine("{0} + {1} = {2} - even", N1, N2, res);
                            }
                            else if (EvenOrOdd == 1)
                            {
                                Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, res);
                            }

                        }
                        else if (symbol == "-")
                        {
                            var res = N1 - N2;
                            var EvenOrOdd = res % 2;
                            if (EvenOrOdd == 0)
                            {
                                Console.WriteLine("{0} - {1} = {2} - even", N1, N2, res);
                            }
                            else if (EvenOrOdd == 1)
                            {
                                Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, res);
                            }
                        }
                        else if (symbol == "*")
                        {
                            var res = N1 * N2;
                            var EvenOrOdd = res % 2;
                            if (EvenOrOdd == 0)
                            {
                                Console.WriteLine("{0} * {1} = {2} - even", N1, N2, res);
                            }
                            else if (EvenOrOdd == 1)
                            {
                                Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, res);
                            }
                        }
                        else if (symbol == "/")
                        {
                            if (N2 == 0)
                            {
                                Console.WriteLine("Cannot divide {0} by zero", N1);
                            }
                            else
                            {
                            
                                double res = N1 / N2;
                                var res1 = Math.Round(res, 2);
                                Console.WriteLine("{0} / {1} = {2}", N1, N2, res1);
                            }
                            
                        }
                        else if (symbol == "%")
                        {
                            if (N2 == 0)
                            {
                                Console.WriteLine("Cannot divide {0} by zero", N1);
                            }
                            else
                            {
                                double res = N1 % N2;
                                var res1 = Math.Round(res, 2);
                                var EvenOrOdd = res1 % 2;
                                if (EvenOrOdd == 0)
                                {
                                    Console.WriteLine("{0} % {1} = 0 ", N1, N2);
                                }
                                else
                                {
                                    Console.WriteLine("{0} % {1} = 1 ", N1, N2);
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}
