
using System;

interface ICalculations
{
    void Add(int a, int b);
    void Sub(int a, int b);
}

interface ICalculations2
{
    void Mul(int a, int b);
    void Div(int a, int b);
}

class Calculators : ICalculations, ICalculations2
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Div(int a, int b)
    {
        Console.WriteLine("Division: " + (a / b));
    }
}

class Calculationprogram
{
    static void Main()
    {
        Calculators obj = new Calculators();

        obj.Add(10, 5);
        obj.Sub(10, 5);
        obj.Mul(10, 5);
        obj.Div(10, 5);
    }
}

