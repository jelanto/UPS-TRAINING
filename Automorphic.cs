using System;

public class Automorphic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int square = num * num;
        int temp = num;
        int divisor = 1;

        while (temp > 0)
        {
            divisor = divisor * 10;
            temp = temp / 10;
        }

        if (square % divisor == num)
        {
            Console.WriteLine("Automorphic Number");
        }
        else
        {
            Console.WriteLine("Not an Automorphic Number");
        }
    }
}