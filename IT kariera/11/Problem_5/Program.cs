﻿using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
           while (num <= n )
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
