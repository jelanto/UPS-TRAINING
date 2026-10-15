using System;
public class Countofdigits
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while(n > 0)
        {
            int r = n % 10;
            count = count + 1;
            n = n / 10;
        }
        Console.WriteLine("Count of digits is: " + count);
    }
    
}