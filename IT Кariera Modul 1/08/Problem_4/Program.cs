using System;

namespace Wine_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input area: ");
            var X = double.Parse(Console.ReadLine());
            Console.Write("Input grapes per m^2: ");
            var Y = double.Parse(Console.ReadLine());
            Console.Write("Needed liters of wine: ");
            var Z = double.Parse(Console.ReadLine());
            Console.Write("Number of workers: ");
            var workers = int.Parse(Console.ReadLine());
            if (X >= 10 && X <= 5000)
            {
                if (Y >= 0.00 && Y <= 10.00)
                {
                    if (Z >= 10 && Z <= 600)
                    {
                        if (workers >= 1 && workers <= 20)
                        {
                            var SumOfGrapes = X * Y;
                            var wine = (SumOfGrapes * 0.4) / 2.5;

                            if (wine > Z)
                            {
                                Console.WriteLine("Good harvest this year! Total Wine: {0} liters.", wine);
                                var dif = wine - Z;
                                var LitersPerPerson =Math.Round( (dif / workers), 0);
                                Console.WriteLine("{0} liters left -> {1} liters per person.", dif, LitersPerPerson );
                            }
                            else if (wine < Z)
                            {
                                Console.Write("It will be a tough winter! ");
                                var dif1 = Math.Round(Z - wine, 0);
                                Console.WriteLine("More {0} liters wine needed.", dif1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
