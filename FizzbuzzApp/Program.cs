using System;

namespace FizzbuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbc = new FizzbuzzCalculator();

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(fbc.Fizzbuzz(i));
            }
        }
    }
}