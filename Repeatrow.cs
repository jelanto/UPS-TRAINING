
using System;

public class Repeatrow
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (j <= i)
                    Console.Write(i);
                else
                    Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
