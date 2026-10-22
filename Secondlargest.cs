using System;
public class Secondlargest
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

        int first = arr[0];
        int second = int.MinValue;
        int temp;

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > first)
            {
                temp = first;
                first = arr[i];
                second = temp;
            }
            else if (arr[i] > second && arr[i] < first)
            {
                second = arr[i];
            }
        }

        Console.WriteLine("Second largest: " + second);
    }
}