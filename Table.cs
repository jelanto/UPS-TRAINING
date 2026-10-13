
using System;

public class Table
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to print its table:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " x " + number + " = " + (i * number));
        }
    }
}
