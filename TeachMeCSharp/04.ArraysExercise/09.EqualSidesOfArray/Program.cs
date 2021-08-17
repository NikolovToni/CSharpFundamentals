using System;
using System.Linq;

namespace _09.EqualSidesOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i < arr[arr.Length / 2 - 1]; i++) 
            {
                //Console.Write($"{arr[i]} ");
                leftSide += arr[i];
            }

            //Console.WriteLine();
            for (int i = arr.Length / 2; i < arr.Length ; i++)
            {
                //Console.Write($"{arr[i]} ");
                rightSide += arr[i];
            }

            if (leftSide == rightSide)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
