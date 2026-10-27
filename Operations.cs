
using System;

abstract class Operation
{
    
    public abstract void Add(int a, int b);
    public abstract void Sub(int a, int b);
    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiply: " + (a * b));
    }

    public void Div(int a, int b)
    {
        Console.WriteLine("Division: " + (a / b));
    }
}

class Operation1 : Operation
{
    
    public override void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }
    public override void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }
}

class Operationprogram
{
    static void Main()
    {
        Operation obj = new Operation1();

        obj.Add(1, 2);
        obj.Sub(1, 2);
        obj.Mul(1, 2);
        obj.Div(1, 2);
    }
}
