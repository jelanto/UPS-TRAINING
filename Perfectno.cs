using System;
public class Perfectno
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if(n % i == 0)
            {
                sum = sum + i;
            }
        }
        if(sum == n)
        {
            Console.Write("It is a perfect number");
        }
        else
        {
            Console.Write("It is not a perfect number");
        }
    }

        
}