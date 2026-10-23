using System;
public static class Log
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Result with log: " + Math.Log(num));
        Console.WriteLine("Result with log10: " + Math.Log10(num));
    }
}