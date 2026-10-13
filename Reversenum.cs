
using System;

public class Reversenum
{
    public static void Main(string[] args)
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
