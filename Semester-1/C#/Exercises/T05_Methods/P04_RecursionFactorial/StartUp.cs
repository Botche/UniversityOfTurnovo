using System;
using System.Numerics;

namespace P04_RecursionFactorial
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 0;

            factorial = SumFactorial(number);

            Console.WriteLine(factorial);
        }

        private static BigInteger SumFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * SumFactorial(number - 1);
        }
    }
}
