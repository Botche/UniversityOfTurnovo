using System;

namespace P01_LeftAndRightSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers: ");
            int countOfNumbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < countOfNumbers * 2; i++)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());

                if (i< countOfNumbers)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }


            Console.WriteLine("Is left sum is equal to right sum?");
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, the difference is {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
