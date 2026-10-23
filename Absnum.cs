using System;
public static class Absnum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int Num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result: " + Math.Abs(Num));
    }
}