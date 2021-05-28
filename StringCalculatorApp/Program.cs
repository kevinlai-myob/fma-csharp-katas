using System;

namespace StringCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var answer= Console.ReadLine();

            var sc = new StringCalculator();
            sc.StringCalculation(answer);
        }
    }
}