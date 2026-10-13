
using System;

public class Repeatednum
{
    public static void Main(string[] args)
    {
        for (int i = 3; i <= 6; i++)
        {
            for (int j = 3; j < i + 1; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
