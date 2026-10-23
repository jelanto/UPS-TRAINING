using System;

public class Anagram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine()??"".ToLower();

        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine()??"".ToLower();

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        string s1 = new string(arr1);
        string s2 = new string(arr2);

        if (s1 == s2)
        {
            Console.WriteLine("Anagrams");
        }
        else
        {
            Console.WriteLine("Not Anagrams");
        }
    }
}