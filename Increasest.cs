
using System;

public class Pattern8
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = i; j <= 5; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
