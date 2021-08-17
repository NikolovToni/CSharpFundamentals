using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int temp = arr[0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
