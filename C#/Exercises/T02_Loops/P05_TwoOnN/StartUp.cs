using System;

namespace P05_TwoOnN
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int maxPower = int.Parse(Console.ReadLine());
            int num = 1;

            for (int power = 0; power <= maxPower; power++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
