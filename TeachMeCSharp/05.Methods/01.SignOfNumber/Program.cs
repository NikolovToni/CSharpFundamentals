using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.SignOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            GetSignOfNumber(number);
        }

        static void GetSignOfNumber(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    Console.WriteLine($"{number[i]} - positive");
                }
                else if (number[i] < 0)
                {
                    Console.WriteLine($"{number[i]} - negative");
                }
                else
                {
                    Console.WriteLine($"{number[i]} - zero");
                }
            }
        }
    }
}
