using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNumber = int.Parse(Console.ReadLine());

            string[] month = new string[]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(month[monthNumber-1]);
            }
        }
    }
}
