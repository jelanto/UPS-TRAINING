using System;

public class Ktharr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter k:");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < 1 || k > size)
        {
            Console.WriteLine("Invalid k");
            return;
        }

        Array.Sort(arr);

        Console.WriteLine("Kth smallest: " + arr[k - 1]);

        Array.Reverse(arr);

        Console.WriteLine("Kth largest: " + arr[k - 1]);
    }
}