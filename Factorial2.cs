using System;
public class Factorial2
{
    public static void Main(string[] args)
    {
        for(int i = 1; i <= 10; i++)
        {
            int fact = 1;
            for(int j = 1; j <= i; j++)
            {
                fact = fact * j;
            }
            Console.WriteLine(fact);
        }
    
    }
    
}