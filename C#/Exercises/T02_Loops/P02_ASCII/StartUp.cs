using System;

namespace P02_ASCII
{
    class StartUp
    {
        static void Main()
        {
            int countOfNum = int.Parse(Console.ReadLine());
            int evenSum = 0, oddSum = 0;

            for (var i = 1; i <= countOfNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes sum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
