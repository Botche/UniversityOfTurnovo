using System;
using System.Numerics;

namespace P05_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger fibonacciNumber = CalculateFibonacciNumberRecursive(number);

            Console.Write(fibonacciNumber);
        }

        private static BigInteger CalculateFibonacciNumberRecursive(int number)
        {
            if (number == 2)
            {
                return 1;
            }
            if (number <= 1)
            {
                return 0;
            }

            return CalculateFibonacciNumberRecursive(number - 1) + CalculateFibonacciNumberRecursive(number - 2);
        }
    }
}
