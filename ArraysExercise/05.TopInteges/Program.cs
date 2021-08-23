using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.TopInteges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int topInteger;
            for (int i = 0; i < arr.Length; i++)
            {
                topInteger = arr[0];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        topInteger = arr[i];
                    }
                }

                Console.WriteLine(topInteger);
            }


        }
    }
}
