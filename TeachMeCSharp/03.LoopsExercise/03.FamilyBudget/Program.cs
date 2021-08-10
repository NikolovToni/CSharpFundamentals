using System;

namespace _03.FamilyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 20;
            double internet = 15;
            double others = 0;

            double electricityPrice = 0;
            double waterPrice = 0;
            double internetPrice = 0;
            double othersPrice = 0;

            for (int i = 0; i < months; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                electricityPrice += electricity;
                others = electricity + water + internet + ((electricity + water + internet) * 0.2);
            }

            for (int i = 0; i < months; i++)
            {
                waterPrice += water;
                internetPrice += internet;
                othersPrice += others;
            }

            Console.WriteLine($"Electricity: {electricityPrice:F2} BGN");
            Console.WriteLine($"Water: {waterPrice:F2} BGN");
            Console.WriteLine($"internet: {internetPrice:F2} BGN");
            Console.WriteLine($"Others: {othersPrice:F2} BGN");
            Console.WriteLine($"Average: {(electricityPrice + waterPrice + internetPrice + othersPrice) / months:F2} BGN");
        }
    }
}
