using System;

public class Armstrong2
{
    public static void Main(string[] args)
    {
        for (int i = 100; i <= 1000; i++)
        {
            int n = i;
            int sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}