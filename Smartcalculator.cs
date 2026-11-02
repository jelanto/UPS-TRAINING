
using System;

class SmartCalculator
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine()??"";

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers only!");
        }
    }
}
