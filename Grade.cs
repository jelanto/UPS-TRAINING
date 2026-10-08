using System;

public class Grade
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Total Marks:");
        double totalMarks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Obtained Marks:");
        double obtainedMarks = Convert.ToDouble(Console.ReadLine());

        double percentage = (obtainedMarks / totalMarks) * 100;

        Console.WriteLine("Percentage: " + percentage);

        if (percentage >= 90 && percentage <= 100)
        {
            Console.WriteLine("Grade A");
        }
        else if (percentage >= 80 && percentage < 90)
        {
            Console.WriteLine("Grade B");
        }
        else if (percentage >= 70 && percentage < 80)
        {
            Console.WriteLine("Grade C");
        }
        else if (percentage >= 60 && percentage < 70)
        {
            Console.WriteLine("Grade D");
        }
        else if (percentage >= 50 && percentage < 60)
        {
            Console.WriteLine("Grade E");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
    }
}