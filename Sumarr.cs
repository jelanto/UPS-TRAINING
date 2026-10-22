using System;

public class Sumarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum of array elements: " + sum);
    }
}