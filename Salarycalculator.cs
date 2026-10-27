using System;
public class Salarycalculator
{
    public void calculatesalary(double salary)
    {
        Console.WriteLine("SALARY:" + salary);
    }
    public void calculatesalary(double salary,double allowance)
    {
        double total = salary + allowance;
        Console.WriteLine("SALARY AND ALLOWANCE:"+ total);
    }
    public void calculatesalary(double salary,double allowance,double bonus)

    {
        double total = salary + allowance + bonus;
        Console.WriteLine("SALARY WITH ALLOWANCE AND BONUS:"+ total);
    }
    public static void Main(String [] args)
    {
        Salarycalculator obj = new Salarycalculator();
        obj.calculatesalary(500000.00);
        obj.calculatesalary(500000.00,7000.00);
        obj.calculatesalary(500000.00,7000.00,3000.00);

    }

}