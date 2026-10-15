using System;
public class Harshadno
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int sum = 0;
        while(n > 0)
        {
            int r = n % 10;
            sum = sum + r;
            n = n / 10;
        }
        if(original % sum == 0)
        {
            Console.Write("It is a Harshad number");
        }
        else
        {
            Console.Write("It is not a Strong number");
        }
        
    }
    
}