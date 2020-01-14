using System;

namespace P01_PrintNumbersFrom1ToN
{
    class StartUp
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Print numbers in descending order:");
            PrintNumbersInDescendingOrder(num);
        }

        private static void PrintNumbersInAscendingOrder(int num)
        {
            int counter = 1;

            if (counter < num)
            {
                PrintNumbersInAscendingOrder(num - 1);
            }

            Console.WriteLine(num);
        }

        private static void PrintNumbersInDescendingOrder(int num)
        {
            int counter = 1;

            Console.WriteLine(num);

            if (counter < num)
            {
                PrintNumbersInDescendingOrder(num - 1);
            }
        }
    }
}
