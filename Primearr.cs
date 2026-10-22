using System;

public static class Primearr
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

        for (int j = 0; j < size; j++)
        {
            int n = arr[j];
            bool prime = true;

            if (n < 2)
            {
                Console.WriteLine(n + " is neither prime nor composite");
                continue;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is a composite number");
        }
    }
}