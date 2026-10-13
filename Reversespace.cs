using System;

public class Reversespace
{
    public static void Main(string[] args)
    {
        for (int i = 4; i > 0; i--)
        {
            for (int k = 4 - i; k > 0; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}