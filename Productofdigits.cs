using System;
public class Productofdigits
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int product = 1;
        while(n > 0)
        {
            int r = n % 10;
            product = product * r;
            n = n / 10;
        }
        Console.WriteLine("Product of digits is: " + product);
    }
    
}