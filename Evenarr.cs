using System;

public class Evenarr
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

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Even number count: " + count);
    }
}