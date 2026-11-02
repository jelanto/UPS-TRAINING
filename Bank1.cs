
using System;

public class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message)
    {
    }
}

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

public class BankAccount
{
    private double balance = 20000;

    // Deposit Method
    public void Deposit()
    {
        Console.Write("\nEnter deposit amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidAmountException(
                "Deposit amount must be greater than zero.");
        }

        balance += amount;

        Console.WriteLine("Deposit successful!");
    }

    // Withdraw Method
    public void Withdraw()
    {
        Console.Write("\nEnter withdrawal amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidAmountException(
                "Withdrawal amount must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Insufficient balance.");
        }

        balance -= amount;

        Console.WriteLine("Withdrawal successful!");
    }

    // Check Balance Method
    public void CheckBalance()
    {
        Console.WriteLine("\nAvailable Balance: " + balance);
    }

    // Main Method
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        Console.WriteLine("===== BANK ACCOUNT MANAGEMENT =====");

        Console.WriteLine("\n1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check Balance");

        Console.Write("\nEnter your choice: ");

        string choice = Console.ReadLine()??"";

        try
        {
            switch (choice)
            {
                case "1":
                    account.Deposit();
                    break;

                case "2":
                    account.Withdraw();
                    break;

                case "3":
                    account.CheckBalance();
                    break;

                default:
                    throw new InvalidAmountException(
                        "Invalid choice. Select 1, 2 or 3.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Error: Please enter a valid numeric amount.");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\n===== TRANSACTION SUMMARY =====");

            account.CheckBalance();

            Console.WriteLine("Transaction process completed.");
        }
    }
}
