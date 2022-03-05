using System;

namespace Laminat_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneSquareAreaPrice = double.Parse(Console.ReadLine());
            if (oneSquareAreaPrice >= 0 && oneSquareAreaPrice <= 999)
            {
                double roomLenght = double.Parse(Console.ReadLine());
                if (roomLenght >= 0 && roomLenght <= 999)
                {
                    double roomHeight = double.Parse(Console.ReadLine());
                    if (roomHeight >= 0 && roomHeight <= 999)
                    {
                       double oneSquareAreaUnderneath = double.Parse(Console.ReadLine());
                        if (oneSquareAreaUnderneath >= 0 && oneSquareAreaUnderneath <= 999)
                        {
                            double area = roomHeight * roomLenght;
                            double laminatPrice = area * oneSquareAreaPrice;
                            double underneathPrice = oneSquareAreaUnderneath * area;
                            double priceSum = laminatPrice + underneathPrice;
                            double montageSum = 0.4 * priceSum;
                            double finalSum = montageSum + priceSum;
                            Console.WriteLine($"{finalSum:F2}");
                        }
                    }
                }
            }
        }
    }
}
