using System;

static class StringExtension
{
    public static int CountVowels(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in text)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}

class Vowels
{
    static void Main()
    {
        string name = "Scope Tech Software Solution.I like to learn C# programming language. I am learning C# from Scope Tech Software Solution.";

        int count = name.CountVowels();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Vowel Count: " + count);
    }
}
