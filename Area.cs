using System;

public class Area
{
    public static void Main()
    {
        Random random = new Random();
        double radius = random.Next(2, 10);
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Area = " + area);
    }
}