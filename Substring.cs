using System;

public class Substring
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine()??"";
        Console.WriteLine("Enter substring:");
        string sub = Console.ReadLine()??"";
        int count = 0;

        if (sub.Length > 0)
        {
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                if (str.Substring(i, sub.Length) == sub)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Occurrences = " + count);
    }
}