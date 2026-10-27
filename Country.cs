using System;

class India
{
    string country;

    public India(string country)
    {
        this.country = country;
        Console.WriteLine("Country Name: " + country);
    }

    public void Capital()
    {
        Console.WriteLine("Capital: New Delhi");
    }

    public void Language()
    {
        Console.WriteLine("Language: Hindi");
    }
}

class USA
{
    string country;

    public USA(string country)
    {
        this.country = country;
        Console.WriteLine("Country Name: " + country);
    }

    public void Capital()
    {
        Console.WriteLine("Capital: Washington, D.C.");
    }

    public void Language()
    {
        Console.WriteLine("Language: English");
    }
}

class UK
{
    string country;

    public UK(string country)
    {
        this.country = country;
        Console.WriteLine("Country Name: " + country);
    }

    public void Capital()
    {
        Console.WriteLine("Capital: London");
    }

    public void Language()
    {
        Console.WriteLine("Language: English");
    }
}

class CountryProgram
{
    static void Main()
    {
        India i = new India("India");
        i.Capital();
        i.Language();
        USA u = new USA("USA");
        u.Capital();
        u.Language();
        UK k = new UK("UK");
        k.Capital();
        k.Language();
    }
}