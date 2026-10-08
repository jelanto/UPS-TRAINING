using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Marks:");
        double marks = Convert.ToDouble(Console.ReadLine());

        double fees = 100000;

        if (marks > 90)
        {
            fees = fees * 0.50;
            Console.WriteLine("50% Scholarship");
            Console.WriteLine("Fees to Pay: " + fees);
        }
        else
        {
            Console.WriteLine("No Scholarship");
            Console.WriteLine("Fees to Pay: " + fees);
        }
    }
}