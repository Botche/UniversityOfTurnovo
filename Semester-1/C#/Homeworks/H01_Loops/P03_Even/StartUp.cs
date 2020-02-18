using System;
using System.Text.RegularExpressions;

namespace P03_Even
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string numAsStr = Console.ReadLine();
            Regex pattern = new Regex(@"[a-zA-Z]");

            while (pattern.IsMatch(numAsStr))
            {
                numAsStr = Console.ReadLine();
            }

            for (int i = 0; i < numAsStr.Length; i++)
            {
                if (numAsStr[i] % 2 == 0)
                {
                    Console.Write(numAsStr[i] + " ");
                }
            }
        }
    }
}
