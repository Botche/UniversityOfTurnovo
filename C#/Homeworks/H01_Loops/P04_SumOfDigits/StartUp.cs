using System;

namespace P04_SumOfDigits
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int partOfNum = num % 10;

                sum += partOfNum;

                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
