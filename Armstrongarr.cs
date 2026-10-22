using System;

public class Armstrongarr
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
            int sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (sum == arr[i])
            {
                Console.WriteLine(arr[i] + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(arr[i] + " is not an Armstrong number");
            }
        }
    }
}