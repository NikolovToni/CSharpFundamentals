using System;

namespace _06.Carousel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int n = int.Parse(Console.ReadLine());

            Carousel(arr, n);
        }

        static void Carousel(int[] arr, int n)
        {
            int temp = arr[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
