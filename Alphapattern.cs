
using System;

public class Alphapattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (char j = 'A'; j < 'A' + i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

