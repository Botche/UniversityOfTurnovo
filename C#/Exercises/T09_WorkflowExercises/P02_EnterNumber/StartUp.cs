using System;

namespace P02_EnterNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
			try
			{
                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Your number is {num}");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (FormatException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            finally
            {
                Console.WriteLine("Operation ended successfully.");
            }
        }
    }
}
