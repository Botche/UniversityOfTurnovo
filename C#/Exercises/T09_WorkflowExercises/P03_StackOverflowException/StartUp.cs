using System;

namespace P03_StackOverflowException
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Recursion();
            }
            catch (Exception soe)
            {
                Console.WriteLine(soe.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        private static void Recursion()
        {
            try
            {
                Recursion();
            }
            catch (Exception soe)
            {
                Console.WriteLine(soe.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
