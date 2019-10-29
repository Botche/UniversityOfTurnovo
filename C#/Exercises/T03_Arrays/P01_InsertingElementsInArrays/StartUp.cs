using System;

namespace P01_InsertingElementsInArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Insert length of array: ");
            int lenghtOfArray = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arrOfNumbers = new int[lenghtOfArray];

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                arrOfNumbers[i] = num;
            }

            Console.WriteLine();
            Console.Write("Array: ");
            Console.WriteLine(string.Join(", ",arrOfNumbers));
        }
    }
}
