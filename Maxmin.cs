using System;
public static class Maxmin
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a num1:");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a num2:");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result of MAX: " + Math.Max(Num1, Num2));
        Console.WriteLine("Result of MIN: " + Math.Min(Num1, Num2));

    }
}