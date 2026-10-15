using System;

public class Twistedprimenum
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int reverse = 0;
        while (n > 0)
        {
            int r = n % 10;
            reverse = reverse * 10 + r;
            n = n / 10;
        }
        int count = 0;
        for(int i=1;i<=reverse;i++)
        {
            if(reverse%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            Console.Write("It is a Twisted Prime number");
        }
        else
        {
            Console.Write("It is not a Twisted Prime number");
        }
    }
}