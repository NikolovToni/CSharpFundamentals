﻿using System;

namespace _02.OneToNThrough
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=m)
            {
                Console.WriteLine(i);
            }
        }
    }
}
