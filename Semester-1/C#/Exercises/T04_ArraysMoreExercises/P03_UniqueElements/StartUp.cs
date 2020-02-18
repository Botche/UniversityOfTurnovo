using System;

namespace P03_UniqueElements
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

            for (int i = 0; i < lengthOfArray; i++)
            {
                bool isDublicate = false;
                for (int j = 0; j < lengthOfArray; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        isDublicate = true;
                        break;
                    }
                }

                if (!isDublicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
