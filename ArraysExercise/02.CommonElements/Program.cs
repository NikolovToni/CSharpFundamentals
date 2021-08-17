using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write($"{secondArray[i]} ");
                    }

                    // Console.WriteLine($"{firstArray[i]} {secondArray[j]}");
                }
            }
        }
    }
}
