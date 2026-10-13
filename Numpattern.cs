using System;

public class Numpattern
{
    public static void Main(string[] args)
    {
        for (int i = 2; i <= 8; i=i+2)
        {
            for (int j = 2; j <= i; j=j+2)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }
    }
}
