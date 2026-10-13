
using System;

public class Reverseodd
{
    public static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i * 2 - 1; j=j+2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}