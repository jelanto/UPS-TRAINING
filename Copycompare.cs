using System;

public class Copycompare
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Copy(arr1, arr2, size);

        for (int i = 0; i < size; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine("Arrays are not equal");
                return;
            }
        }
        Console.WriteLine("Arrays are equal");
    }
}