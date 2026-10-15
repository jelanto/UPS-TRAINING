using System;

public class Twistedprime
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

        if (original == reverse)
        {
            Console.Write("It is a Palindrome number");
        }
        else
        {
            Console.Write("It is not a Palindrome number");
        }
    }
}