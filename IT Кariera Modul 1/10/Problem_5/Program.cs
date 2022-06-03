using System;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstAndLastRow = "+ ";
            for (int i = 0; i < n - 2; i++)
            {
                firstAndLastRow += "- ";
            }
           
            firstAndLastRow += "+";
            Console.WriteLine(firstAndLastRow);
            string middleRows = "| ";
            for (int row = 0; row < n - 2; row++ )
            {
               
                    middleRows += "- ";
                
               
            }
 middleRows += "|";
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(middleRows);
            }
          
            Console.WriteLine(firstAndLastRow);
        }
    }
}
