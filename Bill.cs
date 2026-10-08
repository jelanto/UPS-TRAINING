using System;

public class Hello
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
        double finalAmount;

        if (totalAmount > 5000)
        {
            double discount = totalAmount * 0.18;
            double discountedAmount = totalAmount - discount;

            double gst = discountedAmount * 0.12;
            finalAmount = discountedAmount + gst;
        }
        else
        {
            double gst = totalAmount * 0.12;
            finalAmount = totalAmount + gst;
        }

        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Total Amount: " + totalAmount);
        Console.WriteLine("Final Amount: " + finalAmount);
    }
}