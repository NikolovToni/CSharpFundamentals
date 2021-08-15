using System;
using System.Linq;

namespace _05.EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                }
                else
                {
                    sumOdd += arr[i];
                }
            }

            int difference = sumEven - sumOdd;

            if (difference > 0)
            {
                Console.WriteLine(difference);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
