using System;

public class Reversearr
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
        Console.WriteLine("Reversed Array:");
        for (int j = size - 1; j >= 0; j--)
        {
            Console.WriteLine(arr[j]);
        }

        
    }
}
