using System;
public static class Power
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a base number:");
        double baseNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter an exponent:");
        double exponent = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Result: " + Math.Pow(baseNum, exponent));
    }
}