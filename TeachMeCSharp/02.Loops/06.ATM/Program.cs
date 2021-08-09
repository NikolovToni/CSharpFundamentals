using System;

namespace _06.ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double import;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                import = double.Parse(Console.ReadLine());

                if (import > 0)
                {
                    Console.WriteLine($"Increase: {import}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += import;
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
