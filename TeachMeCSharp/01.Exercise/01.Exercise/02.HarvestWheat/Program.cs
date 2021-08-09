using System;

namespace _02.HarvestWheat
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grain = double.Parse(Console.ReadLine());
            int needFlour = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalWheat = area * grain;
            double totalFlour = 0.4 * totalWheat / 2.5;

            if (totalFlour < needFlour)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needFlour - totalFlour)} kilos needed");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total flour: {Math.Floor(totalWheat)} kilos.");
                Console.WriteLine($"{Math.Ceiling(totalFlour - needFlour)} kilos left -> {Math.Ceiling((totalFlour - needFlour) / workers)}");
            }
        }
    }
}
