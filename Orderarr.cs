using System;
public class Orderarr
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
        Array.Sort(arr);
        Console.WriteLine("Ascending order:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Array.Reverse(arr);
        Console.WriteLine("Descending order:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}