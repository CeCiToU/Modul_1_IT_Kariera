using System;

namespace VIP_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Money capacity [1 000 - 1 000 000]: ");
            var money = double.Parse(Console.ReadLine());
            if (money >= 1000.00 && money <= 1000000.00)
            {
                Console.Write("Choose kategory (VIP / Normal): ");
                var kategory = Console.ReadLine().ToLower();
                if (kategory == "vip" || kategory == "normal")
                {
                    Console.Write("Number of people [1 - 200]: ");
                    var NumOfPeople = int.Parse(Console.ReadLine());
                    if (NumOfPeople >= 1 && NumOfPeople <= 200)
                    {
                        if (NumOfPeople >= 1 && NumOfPeople <= 4)
                        {
                            if (kategory == "normal")
                            {
                                var sum = money * 0.75;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 249.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                            else if (kategory == "vip")
                            {
                                var sum = money * 0.75;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 499.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                        }
                        //100%


                        else if (NumOfPeople >= 5 && NumOfPeople <= 9)
                        {
                            if (kategory == "normal")
                            {
                                var sum = money * 0.60;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 249.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                            else if (kategory == "vip")
                            {
                                var sum = money * 0.60;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 499.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }
                            }
                        }
                        //100%
                        else if (NumOfPeople >= 10 && NumOfPeople <= 24)
                        {
                            if (kategory == "normal")
                            {
                                var sum = money * 0.50;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 249.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                            else if (kategory == "vip")
                            {
                                var sum = money * 0.50;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 499.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }
                            }
                        }
                        //100%
                        else if (NumOfPeople >= 25 && NumOfPeople <= 49)
                        {
                            if (kategory == "normal")
                            {
                                var sum = money * 0.40;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 249.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                            else if (kategory == "vip")
                            {
                                var sum = money * 0.40;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 499.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }
                            }
                        }

                        else if (NumOfPeople >= 50 && NumOfPeople <= 200)
                        {
                            if (kategory == "normal")
                            {
                                var sum = money * 0.25;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 249.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }

                            }
                            else if (kategory == "vip")
                            {
                                var sum = money * 0.25;
                                var sum1 = money - sum;
                                var sum2 = sum1 - 499.99 * NumOfPeople;
                                var sum3 = Math.Round(sum2, 2);
                                if (sum3 > 0)
                                {
                                    Console.WriteLine("Yes! You have {0} leva left.", sum3);
                                }
                                else if (sum3 < 0)
                                {
                                    var sum4 = Math.Abs(Math.Round(sum2, 2));
                                    Console.WriteLine("Not enough money! You need {0} leva.", sum4);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
