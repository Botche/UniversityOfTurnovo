using System;

namespace P02_FindSumFromOneToN
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = FindSum(num);

            Console.WriteLine(sum);
        }

        private static int FindSum(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            return num + FindSum(num - 1);
        }
    }
}
