using System;
using System.Linq;

namespace P04_SortedArraysInSortedArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] firstSortedArray = InitializeArray();
            int[] secondSortedArray = InitializeArray();

            int[] combinedSortedArray = new int[firstSortedArray.Length + secondSortedArray.Length];

            int counterCombinedArray = 0;

            int firstIndex = 0;
            int secondIndex = 0;

            bool firstIncluded = true;

            while (true)
            {
                if (firstIndex == firstSortedArray.Length)
                {
                    firstIncluded = false;
                    break;
                }
                if (secondIndex == secondSortedArray.Length)
                {
                    break;
                }

                int firstNum = firstSortedArray[firstIndex];
                int secondNum = secondSortedArray[secondIndex];

                if (firstNum < secondNum)
                {
                    int num = firstNum;
                    combinedSortedArray[counterCombinedArray] = num;

                    firstIndex++;
                }
                else if (firstNum > secondNum)
                {
                    int num = secondNum;
                    combinedSortedArray[counterCombinedArray] = num;

                    secondIndex++;
                }
                else
                {
                    int num = secondNum;
                    combinedSortedArray[counterCombinedArray] = num;

                    firstIndex++;
                    secondIndex++;
                }

                counterCombinedArray++;
            }

            if (firstIncluded)
            {
                for (int i = firstIndex; i < firstSortedArray.Length; i++)
                {
                    combinedSortedArray[counterCombinedArray] = firstSortedArray[firstIndex];
                    counterCombinedArray++;
                }
            }
            else
            {
                for (int i = secondIndex; i < secondSortedArray.Length; i++)
                {
                    combinedSortedArray[counterCombinedArray] = secondSortedArray[secondIndex];
                    counterCombinedArray++;
                }
            }

            for (int i = 0; i < counterCombinedArray; i++)
            {
                Console.Write(combinedSortedArray[i] + " ");
            }
        }

        private static int[] InitializeArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
