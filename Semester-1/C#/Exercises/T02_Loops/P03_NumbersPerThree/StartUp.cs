using System;
using System.Diagnostics;

namespace P03_NumbersPerThree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = 15;

            for (int i = 1; i <= num; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
