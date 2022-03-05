using System;

namespace Christmass_Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            if (0.01 < budget && budget < 1000.00)
            {
                double firstGiftPrice = double.Parse(Console.ReadLine());
                if ( 0.01 < firstGiftPrice && firstGiftPrice < 1000.00)
                {
                    double secondGiftPrice = firstGiftPrice * 0.2;
                    double thirthGiftPrice = secondGiftPrice * 0.7;
                    double fourthGiftPrice = secondGiftPrice * 0.5;
                    double sumOfPrices = firstGiftPrice + secondGiftPrice + thirthGiftPrice + fourthGiftPrice;
                    if (budget >= sumOfPrices)
                    {
                        double moneyLeft = budget - sumOfPrices;
                        Console.WriteLine($"Yes! {moneyLeft:F2} leva left.");
                    }
                    else if (sumOfPrices > budget)
                    {
                        double moneyLeft = sumOfPrices - budget;
                        Console.WriteLine($"No! {moneyLeft:F2} leva needed.");
                    }
                }
            }
        }
    }
}
