using System;

public class Salary
{
    public static void Main(string[] args)
    {
        double totalSalary = 50000;

        Console.WriteLine("Enter Working Days:");
        double workingDays = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Experience:");
        int experience = Convert.ToInt32(Console.ReadLine());

        double salaryPerDay = totalSalary / 26;
        double finalSalary = salaryPerDay * workingDays;

        if (experience > 5)
        {
            double bonus = finalSalary * 0.10;
            finalSalary = finalSalary + bonus;

            Console.WriteLine("Final Salary: " + finalSalary);
        }
        else
        {
            Console.WriteLine("No bonus added.");
            Console.WriteLine("Final Salary: " + finalSalary);
        }

        Console.WriteLine("Salary Per Day: " + salaryPerDay);
    }
}