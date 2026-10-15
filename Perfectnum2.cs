using System;
public class Perfectnum2
{
    public static void Main(string[] args)
    {
        for(int i = 1; i <= 100; i++)
        {
            int sum = 0;
            for(int j = 1; j < i; j++)
            {
                if(i % j == 0)
                {
                    sum = sum + j;
                }
            }
            if(sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}