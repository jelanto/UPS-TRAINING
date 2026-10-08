using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter A:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter B:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Operation (a/s/m/d):");
        string operation = Console.ReadLine() ?? "";

        switch (operation)
        {
            case "a":
                Console.WriteLine(a + b);
                break;

            case "s":
                Console.WriteLine(a - b);
                break;

            case "m":
                Console.WriteLine(a * b);
                break;

            case "d":
                Console.WriteLine(a / b);
                break;

            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}