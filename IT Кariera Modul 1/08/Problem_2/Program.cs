using System;

namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pool volume: ");
            var V = int.Parse(Console.ReadLine());
            Console.Write("Pipe one fill(for one hour): ");
           
            var Pipe1 = double.Parse(Console.ReadLine());
            Console.Write("Pipe two(for one hour): ");
            var Pipe2 = double.Parse(Console.ReadLine());
            Console.Write("Will fill up for(hours): ");
            var H = double.Parse(Console.ReadLine());
            double P1 = Pipe1 * H;
            double P2 = Pipe2 * H;

            double V1 = P1 + P2;


            if (V1 < V)
            {
                double percentageV = (V1 / V) * 100;
                double percentagePipe1 = Math.Round((P1 / V1) * 100);
                double percentagePipe2 = Math.Floor((P2 / V1) * 100);


                Console.WriteLine("The pool is " + percentageV + "% full. Pipe 1: " + percentagePipe1 + "%. Pipe 2: " + percentagePipe2 + "%.");
            }
            else if (V1 > V)
            {
                double overflows = V1 - V;
                Console.WriteLine("For " + H + " hours the pool overflows with {0} liters.", overflows);
            }

        }
    }
}
