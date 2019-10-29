using System;

namespace P04_ReverseLoop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            for (int num = length; num >= 1; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}
