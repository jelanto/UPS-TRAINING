using System;

public class Hello
{
    public static void Main(string[] args)
    {
        string correctUsername = "admin";
        string correctPassword = "admin123";
        Console.Write("Enter Username: ");
        string username = Console.ReadLine() ?? "";
        Console.Write("Enter Password: ");
        string password = Console.ReadLine() ?? "";

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}
