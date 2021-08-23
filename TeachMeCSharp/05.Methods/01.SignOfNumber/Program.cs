using System;

namespace _01.SignOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetSignOfNumber(number);
        }

        static void GetSignOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
