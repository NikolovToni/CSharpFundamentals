using System;

namespace _04.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double amounthExellent = 0;
            double amounthSocial = 0;
            bool canIt = true;

            if (avgGrade >= 5.5)
            {
                amounthExellent = avgGrade * 25;
            }

            if (income < minSalary && avgGrade >= 4.5)
            {
                amounthSocial = minSalary * 0.35;
            }
            else
            {
                canIt = false;
            }

            if (amounthExellent > amounthSocial && canIt == true)
            {
                Console.WriteLine($"You get a scholarship for exellent result {Math.Floor(amounthExellent)} BGN");
            }
            else if (amounthExellent < amounthSocial && canIt == true)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(amounthSocial)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
