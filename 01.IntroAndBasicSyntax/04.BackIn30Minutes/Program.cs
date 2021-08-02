using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 > 59)
            {
                minutes = (minutes + 30) - 60;
                hours++;
            }
            else
            {
                minutes += 30;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            

            //Console.WriteLine($"{hours}:{minutes}");
            Console.WriteLine("{0:00}:{1:00}", hours, minutes);
        }
    }
}
