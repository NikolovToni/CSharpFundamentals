using System;

namespace _05.UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();

            string inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {
                Console.WriteLine("Wrong password!");
                inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    break;
                }
            }
            Console.WriteLine($"Welcome, {user}");
        }
    }
}
