﻿using System;

namespace _05.RhombusOfAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
