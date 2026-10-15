using System;
public static class Prime
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                count++;
                break;
            }
            
        }
        if(count == 0)
        {
            Console.WriteLine(n + " is a prime number");
        }
        else
        {
            Console.WriteLine(n + " is a composite number");
        }

    }
}
        