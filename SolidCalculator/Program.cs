using System;
using SolidCalculator.Operations;

namespace SolidCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double a, b;

            Console.WriteLine("Enter First Number:");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input! Please enter a valid number:");
            }

            Console.WriteLine("Enter Second Number:");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input! Please enter a valid number:");
            }


            IOperation operation = null;
            while (operation == null)
            {
                Console.WriteLine("Choose operation (+, -, *, /):");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        operation = new Addition();
                        break;
                    case "-":
                        operation = new Subtraction();
                        break;
                    case "*":
                        operation = new Multiplication();
                        break;
                    case "/":
                        operation = new Division();
                        break;
                    default:
                        Console.WriteLine("Invalid operation! Please enter one of (+, -, *, /):");
                        break;
                }
            }

            try
            {
                double result = calculator.Execute(operation, a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nPress Enter to Close!");
                Console.ReadLine();
            }

        }
    }
}
