using System;

static class StringExtensions
{
    public static int CountSentences(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] sentences = text.Split(
            new char[] {'.'},
            StringSplitOptions.RemoveEmptyEntries
        );

        return sentences.Length;
    }
}

class Extendprogram
{
    static void Main()
    {
        string name = "Scope Tech Software Solution.I like to learn C# programming language. I am learning C# from Scope Tech Software Solution.";

        int count = name.CountSentences();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Sentence Count: " + count);
    }
}

