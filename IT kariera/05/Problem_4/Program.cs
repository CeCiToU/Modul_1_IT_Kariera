using System;

namespace Guess_The_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type password: ");
            string password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
