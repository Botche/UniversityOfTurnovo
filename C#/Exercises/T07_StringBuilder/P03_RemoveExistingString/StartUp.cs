using System;
using System.Text;

namespace P03_RemoveExistingString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter a string to remove: ");
            string strToRemove = Console.ReadLine();
            Console.WriteLine();

            var sb = new StringBuilder(str);

            if (!string.IsNullOrWhiteSpace(str))
            {
                sb.Replace(strToRemove, "");
            }

            Console.WriteLine("String with removed string, if it contains:");
            Console.WriteLine(sb.ToString());
        }
    }
}
