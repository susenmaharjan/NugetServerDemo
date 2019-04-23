using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"103+504 = {Demo.Common.Calculator.Add(103, 504)} \n");

            Console.WriteLine($"546-287 = {Demo.Common.Calculator.Subtract(546, 287)} \n");

            Console.WriteLine($"84*12 = {Demo.Common.Calculator.Multiply(84, 12)} \n");

            Console.WriteLine($"50000/500 = {Demo.Common.Calculator.Divide(50000, 500)} \n");
        }
    }
}
