using System;

public class Magicarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            int n = arr[i];

            while (n > 9)
            {
                int sum = 0;

                while (n > 0)
                {
                    int r = n % 10;
                    sum = sum + r;
                    n = n / 10;
                }

                n = sum;
            }

            if (n == 1 && arr[i] > 0)
            {
                Console.WriteLine(arr[i] + " is a magic number");
            }
            else
            {
                Console.WriteLine(arr[i] + " is not a magic number");
            }
        }
    }
}