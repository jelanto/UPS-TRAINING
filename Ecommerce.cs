
using System;

public class Ecommerce
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select category (Watch/Stationary/Dress):");
        string category = Console.ReadLine() ?? "";

        int price = 0;
        string coupon = "";

        if (category == "Watch")
        {
            price = 5000;
            coupon = "wat001";
        }
        else if (category == "Stationary")
        {
            price = 3000;
            coupon = "sat002";
        }
        else if (category == "Dress")
        {
            price = 8000;
            coupon = "dre003";
        }
        else
        {
            Console.WriteLine("Invalid category");
            return;
        }

        Console.WriteLine("Enter quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        if (quantity < 5)
        {
            Console.WriteLine("Minimum purchase is 5 items");
            return;
        }

        int total = price * quantity;

        Console.WriteLine("Enter coupon code:");
        string code = Console.ReadLine() ?? "";

        if (code == coupon)
            total = total - (total * 15 / 100);

        Console.WriteLine("Payment method (Gpay/PhonePe):");
        string payment = Console.ReadLine() ?? "";

        if (payment != "Gpay" && payment != "PhonePe")
        {
            Console.WriteLine("Invalid payment method");
            return;
        }

        total = total + 350;

        Console.WriteLine("Product: " + category);
        Console.WriteLine("Final Amount: Rs. " + total);
    }
}