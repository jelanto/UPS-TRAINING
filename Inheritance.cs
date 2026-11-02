using System;

sealed class Bank1
{
    public void Display()
    {
        Console.WriteLine("Welcome to SBI Bank");
    }
}

class BankProgram
{
    static void Main()
    {
        Bank1 b = new Bank1();
        b.Display();
    }
}