using System;

public class Replacedigit
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine()??"";

        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                result = result + "*";
            }
            else
            {
                result = result + str[i];
            }
        }

        Console.WriteLine(result);
    }
}