using System;

public class Bank
{
    public static void Main(string[] args)
    {
        int PIN = 1234;
        int BALANCE = 100000;
        Console.WriteLine("Deposit / Withdrawl:");
        string Choice = Console.ReadLine()??"";
        Console.WriteLine("Enter the Amount:");
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mode of transaction(Cash/Cheque):");
        string Mode = Console.ReadLine()??"";
        if(Choice == "Deposit")
        {
            
            if(Mode == "Cash")
            {
                BALANCE = BALANCE + amount;
                Console.WriteLine("Amount Credited Successfully");
                Console.WriteLine("Your Balance is:" + BALANCE);
            }
            else if(Mode == "Cheque")
            {
                BALANCE = BALANCE + amount;
                Console.WriteLine("Amount Credited Successfully");
                Console.WriteLine("Your Balance is:" + BALANCE);
            }
        }
        else if(Choice == "Withdrawl")
        {
            Console.WriteLine("Enter the PIN:");
            int pin = Convert.ToInt32(Console.ReadLine());
            if(pin == PIN)
            {
                if(amount <= BALANCE)
                {
                    BALANCE = BALANCE - amount;
                    Console.WriteLine("Amount Debited Successfully");
                    Console.WriteLine("Your Balance is:" + BALANCE);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
        
    }

}