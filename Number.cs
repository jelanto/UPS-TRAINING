
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("First Pattern:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        else if (b > a)
        {
            Console.WriteLine("Second Pattern:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}