using System;
public class Sumofdigits
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(n > 0)
        {
            int r = n % 10;
            sum = sum + r;
            n = n / 10;
        }
        Console.WriteLine("Sum of digits is: " + sum);
    }
    
}