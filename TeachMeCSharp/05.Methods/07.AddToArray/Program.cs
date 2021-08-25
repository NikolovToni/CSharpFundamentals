using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.AddToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }

                command.ToArray();
            }
        }
    }
}
