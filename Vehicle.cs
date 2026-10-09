
using System;

public class VehicleRental
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select vehicle (Car/Bike):");
        string vehicle = Console.ReadLine() ?? "";

        int rate = 0;

        if (vehicle == "Car")
            rate = 1000;
        else if (vehicle == "Bike")
            rate = 300;
        else
        {
            Console.WriteLine("Invalid vehicle");
            return;
        }

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age <= 20 || age > 45)
        {
            Console.WriteLine("Age not eligible");
            return;
        }

        Console.WriteLine("Do you have a driving licence? (Yes/No):");
        string licence = Console.ReadLine() ?? "";

        if (licence != "Yes")
        {
            Console.WriteLine("Not eligible for rental");
            return;
        }

        Console.WriteLine("Enter rental days:");
        int days = Convert.ToInt32(Console.ReadLine());

        if (days <= 0)
        {
            Console.WriteLine("Invalid rental duration");
            return;
        }

        int total = rate * days;

        Console.WriteLine("Vehicle: " + vehicle);
        Console.WriteLine("Rental Days: " + days);
        Console.WriteLine("Total Amount: Rs. " + total);
    }
}