using System;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            double windowLenght = double.Parse(Console.ReadLine());
            if (0 <= windowLenght && windowLenght <= 999)
            {
                double windowHeight = double.Parse(Console.ReadLine());
                if ( 0 <= windowLenght && windowLenght <= 999)
                {
                    int camerasNumber = int.Parse(Console.ReadLine());
                    if (3 <= camerasNumber && camerasNumber <= 5 )
                    {
                        string name = Console.ReadLine();
                        if (name == "Dogramichka4You")
                        {
                            if (camerasNumber == 3)
                            {
                                double price = 12 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 4)
                            {
                                double price = 15 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 5)
                            {
                                double price = 20 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                        }
                        else if (name == "TihoToplo")
                        {
                            if (camerasNumber == 3)
                            {
                                double price = 15 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 4)
                            {
                                double price = 14 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 5)
                            {
                                double price = 18 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                        }
                        else if (name == "ChukChuk")
                        {
                            if (camerasNumber == 3)
                            {
                                double price = 14 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 4)
                            {
                                double price = 20 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                            else if (camerasNumber == 5)
                            {
                                double price = 22 ;
                                double area = windowHeight * windowLenght;
                                double finalPrice = price * area;
                                Console.WriteLine($"Goshko has to spend {finalPrice:F2} leva.");
                            }
                        }
                    }
                }
            }
        }
    }
}
