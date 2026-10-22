using System;

public class Freqarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            int count = 1;

            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            int temp = 0;

            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    temp++;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine(arr[i] + " frequency: " + count);
            }
        }
    }
}