using System;

static class StringExtension1
{
    public static string FullName(this string firstname, string lastname)
    {
        if (string.IsNullOrWhiteSpace(firstname))
        {
            return lastname;
        }

        if (string.IsNullOrWhiteSpace(lastname))
        {
            return firstname;
        }

        return firstname + " " + lastname;
    }
}

class Nameprogram
{
    static void Main()
    {
        string firstname = "Jelci";
        string lastname = "Antoniya";

        string fullname = firstname.FullName(lastname);

        Console.WriteLine("First Name: " + firstname);
        Console.WriteLine("Last Name: " + lastname);
        Console.WriteLine("Full Name: " + fullname);
    }
}