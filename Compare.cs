using System;

public class Compare
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Floor = " + Math.Floor(n));
        Console.WriteLine("Ceiling = " + Math.Ceiling(n));
        Console.WriteLine("Round = " + Math.Round(n));
    }
}