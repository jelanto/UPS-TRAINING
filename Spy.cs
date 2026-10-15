using System;
public class Sumofdigits
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int product = 1;
        while(n > 0)
        {
            int r = n % 10;
            sum = sum + r;
            product = product * r;
            n = n / 10;
        }
        if(sum == product)
        {
            Console.Write("It is a Spy number");
        }
        else
        {
            Console.Write("It is not a Spy number");
        }
    }
    
}