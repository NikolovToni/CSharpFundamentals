using System;

namespace _04.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());


            switch (command)
            {
                case "add":
                    Console.WriteLine(Add(firstNum, secondNum));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(firstNum, secondNum));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(firstNum, secondNum));
                    break;
                case "divide":
                    Console.WriteLine(Divide(firstNum, secondNum));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
