using System;

namespace _05.RepeatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Repeating(word, count);
        }

        static void Repeating(string word, int count)
        {
            string temp = string.Empty;
            for (int i = 0; i < count; i++)
            {
                temp += word;
            }

            Console.WriteLine(temp);
        }
    }
}
