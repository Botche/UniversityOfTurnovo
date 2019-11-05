using System;

namespace P02_DuplicateElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a length of array: ");
            int lengthOfArray = int.Parse(Console.ReadLine());

            int[,] arr = new int[lengthOfArray, 2];

            for (int i = 0; i < lengthOfArray; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                arr[i, 0] = num;
                arr[i, 1] = 0;
            }

            int counterOfDublicatedMembers = 0;

            for (int i = 0; i < lengthOfArray; i++)
            {
                for (int j = i + 1; j < lengthOfArray; j++)
                {
                    if (arr[i, 0] == arr[j, 0])
                    {
                        if (arr[i, 1] == 0)
                        {
                            counterOfDublicatedMembers++;
                        }

                        arr[j, 1] = 1;

                        break;
                    }
                }
            }

            Console.WriteLine($"Counter of dublicated numbers is: {counterOfDublicatedMembers}");
        }
    }
}
