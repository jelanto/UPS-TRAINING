using System;

public class Bill
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Product Name:");
        string productName = Console.ReadLine() ?? "";

        Console.WriteLine("Enter Quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Amount:");
        double amount = Convert.ToDouble(Console.ReadLine());

        double totalAmount = quantity * amount;

        if (totalAmount > 5000)
        {
            double discount = totalAmount * 0.18;
            totalAmount = totalAmount - discount;

            double gst = totalAmount * 0.12;
            totalAmount = totalAmount + gst;
        }
        else
        {
            Console.WriteLine("No discount or GST applied.");
            Console.WriteLine("Final Amount: " + totalAmount);
        }

        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Final Amount: " + totalAmount);
    }
}