using System;

public class Exponential
{
    public static void Main()
    {
        Console.WriteLine("Enter initial population:");
        double initial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter growth rate:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number of years:");
        int years = Convert.ToInt32(Console.ReadLine());
        double population = initial * Math.Exp(rate * years);
        Console.WriteLine("Population = " + population);
    }
}