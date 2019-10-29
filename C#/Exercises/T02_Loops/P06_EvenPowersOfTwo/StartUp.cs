using System;

namespace P06_EvenPowersOfTwo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int maxPower = int.Parse(Console.ReadLine());
            int num = 1;

            for (int power = 0; power <= maxPower; power+=2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
