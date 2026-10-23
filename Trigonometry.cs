using System;
public static class Trigonometry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an angle:");
        double angle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sine: " + Math.Sin(angle));
        Console.WriteLine("Cosine: " + Math.Cos(angle));
        Console.WriteLine("Tangent: " + Math.Tan(angle));
    }
}