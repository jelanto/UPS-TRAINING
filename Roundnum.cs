using System;
public static class Roundnum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Result: " + Math.Round(num));
    }
}