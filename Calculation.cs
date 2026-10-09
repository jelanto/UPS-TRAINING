using System;
public class Calculation
{
    public static void Main(string[] args)
    {
        int count = 0;
        int sum = 0;
        for (int i = 5; i <= 10; i++)
        {
            Console.WriteLine(i);
            count++;
            sum += i;

        }
        Console.WriteLine("Count: " + count);
        Console.WriteLine("Sum: " + sum);
    }
        
}