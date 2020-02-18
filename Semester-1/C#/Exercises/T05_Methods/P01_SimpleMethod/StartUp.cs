using System;

namespace P01_SimpleMethod
{
    class StartUp
    {
        static double firstOperand = 0;
        static double secondOperand = 0;

        static void Main()
        {
            Console.WriteLine("Enter a expression of type: (operand) (sign) (operand)");
            Console.WriteLine("Example: \"4 + 5\"");

            while (true)
            {
                try
                {
                    string[] expressionTokens = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    firstOperand = int.Parse(expressionTokens[0]);
                    secondOperand= int.Parse(expressionTokens[2]);

                    char sign = char.Parse(expressionTokens[1]);

                    double result = DoMath(sign);

                    PrintResult(result);

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        private static void PrintResult(double result)
        {
            Console.Write($"The result of calculation is: {result}");
        }

        private static double DoMath(char sign)
        {
            double result = 0;

            switch (sign)
            {
                case '+':
                    result = SumMehtod();
                    break;
                case '-':
                    result = SubstractMehtod();
                    break;
                case '/':
                    result = DivideMehtod();
                    break;
                case '*':
                    result = MultiplyMehtod();
                    break;
                default:
                    throw new ArgumentException("Invalid sign! Please enter a new expression!");
            }

            return result;
        }

        private static double SumMehtod()
        {
            double sum = firstOperand + secondOperand;

            return sum;
        }

        private static double SubstractMehtod()
        {
            double sum = firstOperand - secondOperand;

            return sum;
        }

        private static double MultiplyMehtod()
        {
            double sum = firstOperand * secondOperand;

            return sum;
        }

        private static double DivideMehtod()
        {
            double sum = firstOperand / secondOperand;

            return sum;
        }
    }
}
