using System;

namespace P03_PrintEveryDigitFromNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintEveryDigit(num);
        }

        private static void PrintEveryDigit(int num)
        {
            int digit = num % 10;

            if (num > 10)
            {
                PrintEveryDigit(num / 10);
            }

            Console.WriteLine(digit);
        }
    }
}
