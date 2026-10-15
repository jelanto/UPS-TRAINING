using System;
public class Perfectnum
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
        if(sum > n)
        {
            Console.Write("It is a abundant number");
        }
        else if(sum < n)
        {
            Console.Write("It is a deficient number");
        }
        else if(sum == n)
        {
            Console.Write("It is a perfect number");
        }
    }

        
}