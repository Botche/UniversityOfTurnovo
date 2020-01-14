using System;
using System.IO;
using System.Linq;
using System.Text;

namespace P01_FileStream
{
    class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            using (var stream = new StreamWriter(@"TextFile.txt"))
            {
                stream.Write(string.Join(" ", arr));
            }

            using (var stream = new StreamReader(@"TextFile.txt"))
            {
                Console.WriteLine(stream.ReadToEnd()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray()
                    .Sum());
            }
        }
    }
}
