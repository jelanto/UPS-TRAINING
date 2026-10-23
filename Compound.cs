using System;
public static class Compound
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the annual interest rate :");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number of years:");
        int time = Convert.ToInt32(Console.ReadLine());
        double amount = principal * Math.Pow((1 + rate/100), time) - principal;
        Console.WriteLine("The compound interest amount is: " + amount);
    }
}
