using System;

class Mobile
{
    private string brand;
    private string model;
    private int batteryPercentage;
    private int batteryCapacity;

    public Mobile(string b, string m, int capacity, int percentage)
    {
        brand = b;
        model = m;
        batteryCapacity = capacity;
        batteryPercentage = percentage;
    }

    public void ChargeBattery(int percentage)
    {
        if (percentage > 0 && batteryPercentage + percentage <= 100)
        {
            batteryPercentage += percentage;
            Console.WriteLine("Charged: " + percentage + "%");
        }
        else
            Console.WriteLine("Invalid charging");
    }

    public void UseBattery(int percentage)
    {
        if (percentage > 0 && percentage <= batteryPercentage)
            batteryPercentage -= percentage;
        else
            Console.WriteLine("Insufficient battery");
    }

    public void CheckBatteryStatus()
    {
        if (batteryPercentage < 20)
            Console.WriteLine("Status: Low Battery");
        else
            Console.WriteLine("Status: Battery Good");
    }

    public void CalculateRemainingBackup()
    {
        Console.WriteLine("Remaining Backup: " + (batteryPercentage * 5) + " Minutes");
    }

    public void Display()
    {
        Console.WriteLine("Mobile: " + brand);
        Console.WriteLine("Battery Capacity: " + batteryCapacity + " mAh");
        Console.WriteLine("Initial Battery: " + batteryPercentage + "%");
    }
}

class MobileProgram
{
    static void Main()
    {
        Mobile m = new Mobile("Samsung", "Galaxy", 5000, 50);

        m.Display();
        m.ChargeBattery(30);

        Console.WriteLine("Current Battery: 80%");

        m.CalculateRemainingBackup();
        m.CheckBatteryStatus();
    }
}