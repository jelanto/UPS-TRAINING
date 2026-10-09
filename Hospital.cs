using System;
public class Hospital
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of room(General / Private / ICU):");
        string roomType = Console.ReadLine()??"";
        Console.WriteLine("Enter the number of days:");
        int numberOfDays = Convert.ToInt32(Console.ReadLine());
        int roomAmount = 0;
        int consultationFee = 800;
        if(roomType == "General")
        {
            roomAmount = 500;
        }
        else if(roomType == "Private")
        {
            roomAmount = 2000;
        }
        else if(roomType == "ICU")
        {
            roomAmount = 5000;
        }
        int totalAmount = (roomAmount * numberOfDays)+ consultationFee;
        float discount = (int)(totalAmount * 0.05f);
        totalAmount = (int)(totalAmount - discount);
        Console.WriteLine("Total Amount to be paid:" + totalAmount);

    }
        
}