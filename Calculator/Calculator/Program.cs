using System;
using System.Globalization;
using System.Collections.Generic;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validOperators = new List<string> { "+", "-", "/", "*" }

            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.WriteLine("=       Calculator         +");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");

            Console.Write("\nWhich operation type (\"+\" \"-\" \"/\" \"*\"): ");
            string operationType = Console.ReadLine();

            foreach () 
            {
            
            }

            

            bool isValidOperator = false;
            while (!isValidOperator)
            {
                Console.Clear();

                Console.WriteLine("Sorry! :( \nWe can't understand what kind of operation you want.");
                Console.Write("\nPlease, try it again (\"+\" \"-\" \"/\" \"*\"): ");
                operationType = Console.ReadLine();

                switch (operationType) 
                {
                    case "+":
                        isValidOperator = true;
                        break;
                    case "-":
                        isValidOperator = true;
                        break;
                    case "/":

                }
                isValidOperator = operationType == "+" ? true : false;
                isValidOperator = operationType == "-" ? true : false;
                isValidOperator = operationType == "/" ? true : false;
                isValidOperator = operationType == "*" ? true : false;

                Console.Clear();
            }

            if (isValidOperator) {
                Console.WriteLine("First number: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number: ");
                int second = int.Parse(Console.ReadLine());

                double result = 0;
                switch (operationType)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "/":
                        result = first / second;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    default:
                        Console.WriteLine("We can not find your result! Please try it again...");
                        break;
                }

                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
                Console.WriteLine("=       Calculator         ");
                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
                Console.WriteLine("Result:                    +");
                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
                Console.WriteLine($"=\t{first} {operationType} {second} = {result}");
                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
                
            }

        }
    }
}
