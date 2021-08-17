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
            int temp;

            while (n>0)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[0];
                    arr[0] = arr[i + 1];
                    arr[i + 1] = temp;
                    n--;
                }
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
