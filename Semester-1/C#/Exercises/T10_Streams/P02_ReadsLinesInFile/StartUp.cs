using System;
using System.IO;

namespace P02_ReadsLinesInFile
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"TextFile.txt"))
            {
                int counter = 0;
                while (stream.ReadLine() != null)
                {
                    
                    counter++;
                }

                Console.WriteLine(counter);
            }
        }
    }
}
