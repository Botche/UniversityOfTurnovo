using System;

namespace P02_SwitchingValues
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int firstNum = 8;
            int secondNum = 6;

            SwitchValues(ref firstNum, ref secondNum);

            Console.WriteLine($"{firstNum} - {secondNum}");
        }

        private static void SwitchValues(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
