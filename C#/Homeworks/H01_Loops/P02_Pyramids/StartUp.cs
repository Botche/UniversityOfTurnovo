using System;

namespace P02_Pyramids
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lengthOfPyramid = GetLengthOfPyramid();
            string typeOfPyramid = GetTypeOfPyramid();

            if (typeOfPyramid == "normal")
            {
                PrintNormalPyramid(lengthOfPyramid);
            }
            else if (typeOfPyramid == "reverse")
            {
                PrintReversePyramid(lengthOfPyramid);
            }
        }

        private static int GetLengthOfPyramid()
        {
            Console.Write("Enter the length of the Pyramid: ");
            int lengthOfPyramid = int.Parse(Console.ReadLine());

            while (lengthOfPyramid < 0)
            {
                Console.Write("Enter a valid length of Pyramid: ");
                lengthOfPyramid = int.Parse(Console.ReadLine());
            }

            return lengthOfPyramid;
        }

        private static string GetTypeOfPyramid()
        {
            Console.Write("Enter a type of the Pyramid: ");
            string typeOfPyramid = Console.ReadLine().ToLower();

            while (typeOfPyramid != "normal" && typeOfPyramid != "reverse")
            {
                Console.Write("Enter a valid type of Pyramid: ");
                typeOfPyramid = Console.ReadLine().ToLower();
            }

            return typeOfPyramid;
        }

        private static void PrintReversePyramid(int lengthOfPyramid)
        {
            for (int i = 1; i <= lengthOfPyramid; i++)
            {
                Console.Write(new string(' ', i - 1));
                for (int j = 0; j <= lengthOfPyramid - i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintNormalPyramid(int lengthOfPyramid)
        {
            for (int i = lengthOfPyramid; i > 0; i--)
            {
                Console.Write(new string(' ', i - 1));
                for (int j = lengthOfPyramid; j >= 0 + i; j--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
