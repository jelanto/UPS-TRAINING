using System;
public class Copyarr
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
        Console.WriteLine("array 2 elements are:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr2[i]);
        }
    }
}