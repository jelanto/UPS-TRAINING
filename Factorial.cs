using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for(int i = 1; i<= number;i++)
        {
            fact = fact * i;
        }
        Console.WriteLine(fact);
    }
    
}