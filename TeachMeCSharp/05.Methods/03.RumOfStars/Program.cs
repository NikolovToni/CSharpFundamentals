using System;

namespace _03.RumOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            RumOfStars(n);
        }

        static void RumOfStars(int num)
        {
            for (int row = 0; row < num; row++)
            {
                for (int col = 1; col <= num - row; col--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.WriteLine(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
