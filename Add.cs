using System;

public class Add
{
    public void add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void add(string a, string b)
    {
        Console.WriteLine(a +" "+ b);
    }

    public void add(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    public static void Main(string[] args)
    {
        Add obj = new Add();

        obj.add(1, 2);
        obj.add("JELCI", "ANTO");
        obj.add(23.56, 45.67);
    }
}