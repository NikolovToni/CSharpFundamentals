using System;

namespace _10.MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int indexNumber = 0;
            for (int i = start; i <= end; i++)
            {
                
                for (int j = start; j <= end/2; j++)
                {
                    indexNumber++;
                    if (i+j == magicNumber)
                    {
                        Console.WriteLine($"Combination {indexNumber} - ({i} + {j} = {magicNumber}) ");
                        break;
                    }
                }
            }
        }
    }
}
