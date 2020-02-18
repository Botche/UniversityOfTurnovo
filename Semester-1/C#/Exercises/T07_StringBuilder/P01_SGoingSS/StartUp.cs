using System;
using System.Text;

namespace P01_SGoingSS
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var sb = new StringBuilder(text);

            sb.Replace("s", "ss");

            Console.WriteLine(sb.ToString());
        }
    }
}
