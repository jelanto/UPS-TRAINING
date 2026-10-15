using System;

public class Tables2
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j + " x " + i + " = " + (i * j));
            }
            Console.WriteLine();
        }
    }
}