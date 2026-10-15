using System;
public class Strongno
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int sum = 0;
        while(n > 0)
        {
            int r = n % 10;
            int factorial = 1;
            for(int i = 1; i <= r; i++)
            {
                factorial = factorial * i;
            }
            sum = sum + factorial;
            n = n / 10;
        }
        if(sum == original)
        {
            Console.Write("It is a Strong number");
        }
        else
        {
            Console.Write("It is not a Strong number");
        }
        
    }
    
}