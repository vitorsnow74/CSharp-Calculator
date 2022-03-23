using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Basic Calculator V1

            List<string> validOperators = new List<string> { "+", "-", "/", "*" };

            Console.WriteLine(ShowMenu());

            Console.Write("\nChoose the operation you want [\"+\", \"-\", \"/\", \"*\"]: ");
            string calculateType = Console.ReadLine();

            int indexOfCalcType = validOperators.IndexOf(calculateType);
            if (indexOfCalcType == -1)
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine(ShowMenu());

                    Console.WriteLine("\nSorry! :( \nWe can't understand what kind of operation you want.");
                    Console.Write("\nPlease use something like this: [\"+\", \"-\", \"/\", \"*\"]:    ");

                    calculateType = Console.ReadLine();
                    indexOfCalcType = validOperators.IndexOf(calculateType);

                } while (indexOfCalcType == -1);
            }

            Console.Write("\nFirst number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            double result = 0;
            switch (calculateType)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                default:
                    Console.WriteLine("We can not find your result!\nPlease try again later...");
                    break;
            }

            Console.Clear();
            Console.WriteLine(ShowResult(calculateType, firstNumber, secondNumber, result));                            
        }

        public static string ShowMenu() 
        {
            StringBuilder showMenuValues = new StringBuilder();
            showMenuValues.AppendLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            showMenuValues.AppendLine("=       Calculator SELECTED MODE: \"Console\"       =");
            showMenuValues.AppendLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");

            return showMenuValues.ToString();            
        }

        public static string ShowResult(string calculateType, int firstNumber, int secondNumber, double result)
        {
            StringBuilder showResultValues = new StringBuilder();
            showResultValues.AppendLine(ShowMenu());
            showResultValues.AppendLine($"The result of {firstNumber} {calculateType} {secondNumber} is: " +
                                        $"\t {result.ToString("f2", CultureInfo.InvariantCulture)}");
            showResultValues.AppendLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");           

            return showResultValues.ToString();
        }
    }
}