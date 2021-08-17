using System;
using System.Linq;

namespace _08.Carousel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
<<<<<<< HEAD

            int n = int.Parse(Console.ReadLine());
            int temp;

            while (n>0)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[0];
                    arr[0] = arr[i + 1];
                    arr[i + 1] = temp;
                    n--;
=======
            int n = int.Parse(Console.ReadLine());

            int temp = arr[0];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
>>>>>>> 0c7c7a80c0a098bded3aa1d4467c1bd96ba36f20
                }
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
