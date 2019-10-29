using System;
using System.Numerics;

namespace P01_Factorial
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            BigInteger fact = FindFactorialOfNumber(num);

            Console.Write("Factorial of this number: ");
            Console.WriteLine(fact);
        }

        private static BigInteger FindFactorialOfNumber(int num)
        {
            BigInteger fact = new BigInteger(1);

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
