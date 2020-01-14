using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_PrintOddNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

            PrintOddNumbers(input);
        }

        private static void PrintOddNumbers(List<int> input)
        {
            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    continue;
                }
                if (item > 100)
                {
                    break;
                }

                Console.WriteLine(item);
            }
        }
    }
}
