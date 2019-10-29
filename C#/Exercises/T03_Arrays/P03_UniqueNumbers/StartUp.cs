using System;

namespace P03_UniqueNumbers
{
    class StartUp
    {
        static int[,] notUniqueNumbers;
        static int[] numbers;

        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            int length = int.Parse(Console.ReadLine());

            InitializaArray(length);

            notUniqueNumbers = new int[length, 2];

            int notUniqueCounter = 0;
            for (int arrayIndex = 0; arrayIndex < length; arrayIndex++)
            {
                int num = numbers[arrayIndex];

                bool isThere = false;
                for (int twoDimensionalArrayIndex = 0; twoDimensionalArrayIndex < notUniqueCounter; twoDimensionalArrayIndex++)
                {
                    if (num == notUniqueNumbers[twoDimensionalArrayIndex, 0])
                    {
                        notUniqueNumbers[twoDimensionalArrayIndex, 1]++;
                        isThere = true;
                        break;
                    }
                }

                if (!isThere)
                {
                    notUniqueNumbers[notUniqueCounter, 0] = num;
                    notUniqueNumbers[notUniqueCounter, 1] = 1;
                    notUniqueCounter++;
                }

            }

            PrintUniqueElements(notUniqueCounter);

            Console.WriteLine();
            PrintNonUniqueElements(notUniqueCounter);
        }

        private static void InitializaArray(int length)
        {
            numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                numbers[i] = num;
            }
        }

        private static void PrintNonUniqueElements(int notUniqueCounter)
        {
            Console.WriteLine("Non unique elements:");
            for (int i = 0; i < notUniqueCounter; i++)
            {
                if (notUniqueNumbers[i, 1] != 1)
                {
                    Console.WriteLine($"{notUniqueNumbers[i, 0]} - {notUniqueNumbers[i, 1]}");
                }
            }
        }

        private static void PrintUniqueElements(int notUniqueCounter)
        {
            Console.WriteLine("Unique elements:");
            for (int i = 0; i < notUniqueCounter; i++)
            {
                if (notUniqueNumbers[i, 1] == 1)
                {
                    Console.WriteLine(notUniqueNumbers[i, 0]);
                }
            }
        }
    }
}
