using System;
public static class Celcius
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a temperature in Celcius:");
        double Celcius = Convert.ToDouble(Console.ReadLine());
        double result =  (Celcius * 9/5) + 32;
        Console.WriteLine("The temperature is: " + Math.Round(result));
    }
}