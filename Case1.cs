using System;

public class Case1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine() ?? "";

        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Lowercase: " + str.ToLower());
    }
}