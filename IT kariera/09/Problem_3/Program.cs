using System;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet: ");
           
           
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Console.Write(" {0} ", letter);
            }
            Console.WriteLine("");
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(" {0} ", letter);
            }
        }
    }
}
