using System;
using System.Linq;

namespace _P01_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();

                bool[] conditions = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(bool.Parse)
                    .ToArray();

                int caseNumber = conditions[1] ? 1 : 2; 
                if (conditions[0])
                {
                    Console.WriteLine($"case {caseNumber}");
                }
                else
                {
                    Console.WriteLine($"case {caseNumber + 2}");
                }

                watch.Stop();
                Console.WriteLine(watch.Elapsed);
        }
    }
}