using System;

class Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numbers from 1 to 10:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nNumbers from 10 to 1:");

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}