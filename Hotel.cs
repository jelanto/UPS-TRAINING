using System;
public class Hotel
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of room(Standard / Deluxe / Suite):");
        string roomType = Console.ReadLine()??"";
        Console.WriteLine("No. of days:");
        int numberOfDays = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the type of customer(Normal / Membership):");
        string Customertype = Console.ReadLine()??"";
        Console.WriteLine("Do you need food?(Yes/No):");
        string food = Console.ReadLine()??"";
        int roomamount = 0;
        if(roomType == "Standard")
        {
            roomamount = 1000;
        }
        else if(roomType == "Deluxe")
        {
            roomamount = 2000;
        }
        else if(roomType == "Suite")
        {
            roomamount = 3000;
        }
        if(Customertype == "Membership")
        {
            float discount = roomamount * 0.05f;
            roomamount = (int)(roomamount - discount); 
        }
        else
        {
            Console.WriteLine("No discount applied.");
        }
        if(food == "Yes")
        {
            roomamount = roomamount + 500;
        }
        else
        {
            Console.WriteLine("No food charges applied.");
        }
        int gst = (int)(roomamount * numberOfDays * 0.12);
        int totalamount = (roomamount * numberOfDays) + gst;
        Console.WriteLine("Total Amount: " + totalamount);
        Console.WriteLine("\n--- HOTEL BILL ---");
        Console.WriteLine("Room   : " + roomType);
        Console.WriteLine("Amount : Rs. " + roomamount * numberOfDays);
        Console.WriteLine("GST    : Rs. " + gst);
        Console.WriteLine("Total  : Rs. " + totalamount);
       
    }
}