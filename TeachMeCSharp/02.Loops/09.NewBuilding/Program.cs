using System;

namespace _09.NewBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            int lastFloor = 0;
            for (int i = floors; i >= 1; i--)
            {
                if (lastFloor < i)
                {
                    lastFloor = i;
                }

                for (int j = 0; j < rooms; j++)
                {
                    if (i % 2 == 0 && i != lastFloor)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (i % 2 != 0 && i != lastFloor)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"L{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
