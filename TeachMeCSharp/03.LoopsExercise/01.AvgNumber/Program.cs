using System;

namespace _01.AvgNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"{sum / n:F2}");
        }
    }
}
