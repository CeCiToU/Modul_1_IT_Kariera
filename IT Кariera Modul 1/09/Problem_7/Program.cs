using System;

namespace LeftSum_RightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers will have to sum in left and right - ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Left number = ");
                var numLeft = int.Parse(Console.ReadLine());
                Console.WriteLine();
                leftSum += numLeft;
            }

            var rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Right number = ");
                var numRight = int.Parse(Console.ReadLine());
                Console.WriteLine();
                rightSum += numRight;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes , sum = {0}", leftSum);
            }
            else if (leftSum > rightSum)
            {
                var dif = leftSum - rightSum;
                Console.WriteLine("No, dif = {0}", dif);
            }
            else if (leftSum < rightSum)
            {
                var dif = rightSum - leftSum;
                Console.WriteLine("No, dif = {0}", dif);
            }

        }
    }
}
