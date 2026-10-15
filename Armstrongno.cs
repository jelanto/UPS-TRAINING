using System;

public class Armstrongno
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int sum = 0;

        while (n > 0)
        {
            int r = n % 10;
            int cube = r * r * r;
            sum = sum + cube;
            n = n / 10;
        }

        if (sum == original)
        {
            Console.Write("It is an Armstrong number");
        }
        else
        {
            Console.Write("It is not an Armstrong number");
        }
    }
}