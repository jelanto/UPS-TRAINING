
using System;

public class Reverseoddnum
{
    public static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = i * 2 - 1; j >0; j=j-2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}