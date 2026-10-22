using System;

public static class Primecountarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int j = 0; j < size; j++)
        {
            int n = arr[j];
            int c = 0;

            if (n < 2)
                continue;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                    break;
                }
            }

            if (c == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Prime number count: " + count);
    }
}