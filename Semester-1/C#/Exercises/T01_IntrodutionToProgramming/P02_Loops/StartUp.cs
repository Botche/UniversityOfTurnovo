using System;

namespace P02_Loops
{
    class StartUp
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i % 6 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
