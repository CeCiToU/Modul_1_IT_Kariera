using System;

namespace Equal_Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It will answer if the texts are equal right after you insert them.");
            Console.Write("Insert txt1: ");
            string txt1 = Console.ReadLine().ToLower();
            Console.Write("Insert txt2: ");
            string txt2 = Console.ReadLine().ToLower();
           
            if (txt1 == txt2)
            {
                Console.WriteLine("Yes, they are!");
            }
            else
            {
                Console.WriteLine("No, they are not!");
            }

        }
    }
}
