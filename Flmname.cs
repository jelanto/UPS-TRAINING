using System;

static class StringExtension2
{
    public static string FullName(this string firstname, string middlename, string lastname)
    {
        if (string.IsNullOrWhiteSpace(firstname))
        {
            return middlename + " " + lastname;
        }

        if (string.IsNullOrWhiteSpace(middlename))
        {
            return firstname+ " " + lastname;
        }
        if(string.IsNullOrWhiteSpace(lastname))
        {
            return firstname + " " + middlename;
        }

        return firstname + " " + middlename + " " + lastname;
    }
}

class Nameprogram1
{
    static void Main()
    {
        string firstname = "Jelci";
        string middlename = "Antoniya";
        string lastname = "A";

        string fullname = firstname.FullName(middlename, lastname);

        Console.WriteLine("First Name: " + firstname);
        Console.WriteLine("Middle Name: " + middlename);
        Console.WriteLine("Last Name: " + lastname);
        Console.WriteLine("Full Name: " + fullname);
    }
}