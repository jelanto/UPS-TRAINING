using System;
public static class Distance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter X1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y2:");
        double y2 = Convert.ToDouble(Console.ReadLine());
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("The distance between the two points is: " + distance);
    }
}