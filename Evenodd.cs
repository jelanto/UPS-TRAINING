using System;

public class Evenodd
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j%2== 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("#");
                }
                
            }
            Console.WriteLine("");
        }
    }
}
