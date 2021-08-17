using System;
using System.Linq;

namespace _10.TheLongestSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ("1 2 2 3 4 4 2 2 2 1")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string temp = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} {arr[i+1]}");
            }

            Console.WriteLine(temp);
        }
    }
}
