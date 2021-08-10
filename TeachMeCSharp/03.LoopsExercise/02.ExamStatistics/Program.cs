using System;

namespace _02.ExamStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            double studentGrade;

            double sum = 0;
            double topStudents = 0;
            double goodStudents = 0;
            double avgStudents = 0;
            double failStudents = 0;

            for (int i = 0; i < numberStudents; i++)
            {
                studentGrade = double.Parse(Console.ReadLine());

                sum += studentGrade;

                if (studentGrade >= 5)
                {
                    topStudents++;
                }
                else if (studentGrade >= 4 && studentGrade <= 4.99)
                {
                    goodStudents++;
                }
                else if (studentGrade >= 3 && studentGrade <= 3.99)
                {
                    avgStudents++;
                }
                else
                {
                    failStudents++;
                }
            }

            if (topStudents > 0)
            {
                Console.WriteLine($"Top students: {(topStudents / numberStudents) *100:F2}%");
            }

            if (goodStudents > 0)
            {
                Console.WriteLine($"Between 4.00 and 4.99: {(goodStudents / numberStudents) * 100:F2}%");
            }

            if (avgStudents > 0)
            {
                Console.WriteLine($"Between 3.00 and 3.99: {(avgStudents / numberStudents) * 100:F2}%");
            }

            if (failStudents > 0)
            {
                Console.WriteLine($"fail: {(failStudents / numberStudents) * 100:F2}%");
            }

            Console.WriteLine($"Average: {sum/numberStudents:F2}");
        }
    }
}
