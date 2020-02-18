using System;

namespace P01_CopyThatArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a length of array: ");
            int lengthOfArray = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[lengthOfArray];

            for (int i = 0; i < lengthOfArray; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }

            int[] copiedArr = new int[lengthOfArray];

            for (int i = 0; i < lengthOfArray; i++)
            {
                copiedArr[i] = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine("Here is copied array...");
            Console.WriteLine(string.Join(", ", copiedArr));
        }
    }
}
