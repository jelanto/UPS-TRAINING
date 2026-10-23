using System;
public static class Bmi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter weight:");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / Math.Pow(height, 2);
        Console.WriteLine("Your BMI is: " + bmi);
    }
}