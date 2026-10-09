using System;
public class Division
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for(int i =100;i<=150;i++)
        {
            if(i%9==0)
            {
                sum+=i;
            }
        }
        Console.WriteLine("Sum of numbers divisible by 9: " + sum);
    }
}