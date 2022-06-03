using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your score is: ");
            var score = int.Parse(Console.ReadLine());
            if (score <= 100)
            {
                int bonus = 5;
                if (score % 2 == 0)
                {
                    double FinalBonus = bonus + 1;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    double FinalScore = score + FinalBonus ;

                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 10 == 5)
                {
                    double FinalBonus = bonus + 2;
                    double FinalScore = FinalBonus + score;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 2 == 1)
                {
                    double FinalScore = bonus + score;
                    Console.WriteLine("Your bonus points are: " + bonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }

            }
            else if (score <= 1000)
            {
                double bonus = score * 0.2;
                if (score % 2 == 0)
                {
                    double FinalBonus = bonus + 1;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    double FinalScore = score + FinalBonus;
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 10 == 5)
                {
                    double FinalBonus = bonus + 2;
                    double FinalScore = FinalBonus + score;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 2 == 1)
                {
                    double FinalScore = bonus + score;
                    Console.WriteLine("Your bonus points are: " + bonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
            }
            else if (score > 1000)
            {
                double bonus = score * 0.1;
                if (score % 2 == 0)
                {
                    double FinalBonus = bonus + 1;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    double FinalScore = score + FinalBonus;
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 10 == 5)
                {
                    double FinalBonus = bonus + 2;
                    double FinalScore = FinalBonus + score;
                    Console.WriteLine("Your bonus points are: " + FinalBonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
                else if (score % 2 == 1)
                {
                    double FinalScore = bonus + score;
                    Console.WriteLine("Your bonus points are: " + bonus);
                    Console.WriteLine("Your socer now is: " + FinalScore);
                }
            }

        }
    }
}
