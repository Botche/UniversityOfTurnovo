using System;

namespace P03_CountElement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int count = CountSymbols(symbol, text);

            Console.Write($"The count of '{symbol}' symbol is {count}");
        } 

        private static int CountSymbols(char symbol, string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
