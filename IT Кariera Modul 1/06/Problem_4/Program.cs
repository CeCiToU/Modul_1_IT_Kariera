using System;

namespace Convertor_Of_Measuring_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number to convert: ");
            var num = double.Parse(Console.ReadLine());
            Console.Write("First unit is: ");
            string first = Console.ReadLine();
            Console.Write("Second unit is: ");
            string second = Console.ReadLine();
            if (first == "m")
            {
                double m = num;
                if (second == "m")
                {
                    Console.Write(Math.Round(m, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(m * 1000, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(m * 100, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(m * 0.000621371192, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(m * 39.3700787, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(m * 0.001, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(m * 3.2808399, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(m * 1.0936133, 2) + " yd");
                }
            }
            else if (first == "mm")
            {
                double mm = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(mm * 0.001, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(mm, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(mm * 0.1, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(mm * 6.213711919999997e-7, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(mm * 0.0393700787, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(mm * 0.000001, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(mm * 0.0032808399, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(mm * 0.0010936133, 2) + " yd");
                }
                //: m, mm, cm, mi, in, km, ft, yd
            }
            else if (first == "cm")
            {
                double cm = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(cm * 0.01, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(cm * 10, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(cm, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(cm * 6.213711920000008e-6, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(cm * 0.393700787, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(cm / 100000, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(cm * 0.032808399, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(cm * 0.010936133, 2) + " yd");
                }


            }
            else if (first == "mi")
            {
                double mi = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(mi * 1609.34400061469, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(mi * 1609344.000614692, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(mi * 160934.4000614691, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(mi, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(mi * 63359.99995957327, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(mi * 1.609344000614692, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(mi * 5280.000010042291, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(mi * 1760.000003347435, 2) + " yd");
                }

            }
            else if (first == "in")
            {
                double inch = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(inch * 0.025400000025908, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(inch * 25.40000002590801, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(inch * 2.540000002590797, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(inch * 1.578282829289847e-5, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(inch, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(inch * 2.5400000025908e-5, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(inch * 0.0833333335450002, 2) + " ft");
                }
                else if (second == "yd")
                {
                    double a = Math.Round(inch * 0.0277777778483333, 2);
                    Console.WriteLine(a + " yd");
                }


            }
            else if (first == "km")
            {
                double km = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(km * 1000, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(km * 1000000, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(km * 100000, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(km * 0.621371192, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(km * 39370.0787, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(km, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(km * 3280.8399, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(km * 1093.6133, 2) + " yd");
                }
            } //: m, mm, cm, mi, in, km, ft, yd
            else if (first == "ft")
            {
                double ft = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(ft * 0.304799999536704, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(ft * 304.799999536704, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(ft * 30.4799999536704, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(ft * 1.893939390337211e-4, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(ft * 11.99999996952, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(ft * 3.047999995367045e-4, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(ft, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(ft * 0.3333333333333333, 2) + " yd");
                }

            }
            else if (first == "yd")
            {
                double yd = num;
                if (second == "m")
                {
                    Console.WriteLine(Math.Round(yd * 0.9143999986101119, 2) + " m");
                }
                else if (second == "mm")
                {
                    Console.WriteLine(Math.Round(yd * 914.3999986101117, 2) + " mm");
                }
                else if (second == "cm")
                {
                    Console.WriteLine(Math.Round(yd * 91.43999986101117, 2) + " cm");
                }
                else if (second == "mi")
                {
                    Console.WriteLine(Math.Round(yd * 5.68181817101164e-4, 2) + " mi");
                }
                else if (second == "in")
                {
                    Console.WriteLine(Math.Round(yd * 35.99999990855988, 2) + " in");
                }
                else if (second == "km")
                {
                    Console.WriteLine(Math.Round(yd * 9.143999986101124e-4, 2) + " km");
                }
                else if (second == "ft")
                {
                    Console.WriteLine(Math.Round(yd * 3, 2) + " ft");
                }
                else if (second == "yd")
                {
                    Console.WriteLine(Math.Round(yd, 2) + " yd");
                }
            }

        }
    }
}
