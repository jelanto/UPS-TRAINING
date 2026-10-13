using System;

public class Spacealpha
{
    public static void Main(string[] args)
    {
        char ch = 'a';

        for (int i = 1; i <= 3; i++)
        {
            for (int k = 3 - i; k > 0; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(ch);
                ch++;
            }

            Console.WriteLine();
        }
    }
}