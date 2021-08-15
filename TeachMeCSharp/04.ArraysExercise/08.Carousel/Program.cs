using System;
using System.Linq;

namespace _08.Carousel
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
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
