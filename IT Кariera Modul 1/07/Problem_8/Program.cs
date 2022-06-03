using System;

namespace Type_Of_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Animal type: ");
            string name = Console.ReadLine();
            if (name == "dog")
            {
                Console.WriteLine("The animal is mammal");
            }
            else if (name == "crocodile")
            {
                Console.WriteLine("The animal is reptile");
            }
            else if (name == "tortoise")
            {
                Console.WriteLine("The animal is reptile");
            }
            else if (name == "snake")
            {
                Console.WriteLine("The animal is reptile");
            }
            else
            {
                Console.WriteLine("The animal is unknown");
            }

        }
    }
}
