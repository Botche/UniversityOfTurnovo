using System;
using System.Linq;
using System.Text;

namespace P02_StringArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int index = 0; index < str.Length; index++)
            {
                if ((index + 1) % 3 == 0)
                {
                    Console.WriteLine(str[index]);
                }
                else
                {
                    Console.Write(str[index]);
                }
            }
        }
    }
}
