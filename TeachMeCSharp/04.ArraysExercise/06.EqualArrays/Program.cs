using System;
using System.Linq;

namespace _06.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool areEqual = false;
            int sum = 0;
            int index = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                    areEqual = true;
                }
                else
                {
                    index = firstArray[i];
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Equal arrays, Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Not equal. Difference at index {index - 1}");
            }
        }
    }
}
