using System;
using System.Linq;
using System.Text;

namespace P02_ReverseHalfOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string str = "12345";

            var sb = new StringBuilder();
            int counter = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length / 2)
                {
                    sb.Append(str[i]);
                    continue;
                }
                sb.Append(str[str.Length - counter++]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
