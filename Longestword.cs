using System;

public class Longestword
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string str = Console.ReadLine()??"";
        string[] words = str.Split(' ');
        string longest = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }

        Console.WriteLine("Longest word = " + longest);
    }
}