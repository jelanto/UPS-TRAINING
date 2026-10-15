using System;
public class Neonno
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int square = n * n;
        int sum = 0;
        while(square > 0)
        {
            int r = square % 10;
            sum = sum + r;
            square = square / 10;
        }
        if(sum == n)
        {
            Console.Write("It is a Neon number");
        }
        else
        {
            Console.Write("It is not a Neon number");
        }
    }
    
}