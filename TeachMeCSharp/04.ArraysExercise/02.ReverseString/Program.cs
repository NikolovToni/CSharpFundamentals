using System;
using System.Linq;

namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(arr[i-1]);
            }
        }
    }
}
