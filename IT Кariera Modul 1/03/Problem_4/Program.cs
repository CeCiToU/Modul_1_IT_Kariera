using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name - ");
            string FirstName = Console.ReadLine();
            Console.Write("Last name - ");
            string LastName = Console.ReadLine();
            Console.Write("Your age - ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Name of your town - ");
            string town = Console.ReadLine();
            Console.WriteLine("You are " + FirstName + " " + LastName + ", " + age + " " + "years old, from " + town + ".");

        }
    }
}
