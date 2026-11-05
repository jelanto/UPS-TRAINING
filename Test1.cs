using System;
class Account
{
    int accountNumber = 12345;
    string accountHolder = "John";
    protected double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void displayBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    int interestRate = 5;
    public void CalculateInterest()
    {
        double interest = balance * (interestRate / 100.0);

        Console.WriteLine("Initial Balance: " + balance);
        Console.WriteLine("Interest Rate: " + interestRate + "%");
        Console.WriteLine("Annual Interest: " + interest);
    }
}

class CurrentAccount : Account
{
    int OverdraftLimit = 10000;

    public void Withdraw(double amount)
    {
        if (amount <= balance + OverdraftLimit)
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawal: " + amount);
            Console.WriteLine("Remaining Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}

class BankingSystem
{
    static void Main()
    {
        Console.WriteLine("Savings Account:");
        SavingsAccount s = new SavingsAccount();
        s.Deposit(50000);
        s.CalculateInterest();
        Console.WriteLine();
        Console.WriteLine("Current Account:");
        CurrentAccount c = new CurrentAccount();
        c.Deposit(20000);
        Console.WriteLine("Initial Balance: " + 20000);
        c.Withdraw(25000);
    }
}