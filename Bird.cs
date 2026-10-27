using System;

class Birds
{
    protected string name;

    public Birds(string name)
    {
        this.name = name;

        Console.WriteLine("Bird Constructor");
        Console.WriteLine("Bird Name: " + name);
    }

    public void makesound()
    {
        Console.WriteLine("Birds Make Sound");
    }
}

class Parrot : Birds
{
    public Parrot(string name) : base(name)
    {
        Console.WriteLine("Parrot Constructor: " + name);
    }

    public new void makesound()
    {
        base.makesound();
        Console.WriteLine("kee kee " + name);
    }
}

class Sparrow : Birds
{
    public Sparrow(string name) : base(name)
    {
        Console.WriteLine("Sparrow Constructor: " + name);
    }

    public new void makesound()
    {
        base.makesound();
        Console.WriteLine("quak quak " + name);
    }
}

class BirdProgram
{
    public static void Main(string[] args)
    {
        Parrot p = new Parrot("Parrot");
        p.makesound();

        Console.WriteLine();

        Sparrow s = new Sparrow("Sparrow");
        s.makesound();
    }
}