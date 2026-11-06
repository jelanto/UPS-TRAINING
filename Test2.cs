using System;

class Vehicle
{
    public int VehicleNumber;
    public string VehicleName = "";
    public void DisplayRent(string name, int days, int rent, int discount)
    {
        int finalRent = rent - discount;
        Console.WriteLine("Vehicle: " + name);
        Console.WriteLine("Rental Days: " + days);
        Console.WriteLine("Total Rent: " + rent);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Rent: " + finalRent);
    }
    public virtual void CalculateRent(int days)
    {
        Console.WriteLine("Vehicle Rent");
    }
}
class Car : Vehicle
{
    public override void CalculateRent(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days");
            return;
        }
        int rent = 2000 * days;
        int discount = 0;
        if (days > 7)
        {
            discount = rent * 10 / 100;
        }
        DisplayRent("Car", days, rent, discount);
    }
}
class Bike : Vehicle
{
    public override void CalculateRent(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days");
            return;
        }
        int rent = 800 * days;
        int discount = 0;
        if (days > 7)
        {
            discount = rent * 10 / 100;
        }
        DisplayRent("Bike", days, rent, discount);
    }
}

class Bus : Vehicle
{
    public override void CalculateRent(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days");
            return;
        }
        int rent = 5000 * days;
        int discount = 0;
        if (days > 7)
        {
            discount = rent * 10 / 100;
        }
        DisplayRent("Bus", days, rent, discount);
    }
}

class VehicleProgram
{
    static void Main()
    {
        Vehicle v;

        v = new Car();
        v.CalculateRent(10);

        Console.WriteLine();

        v = new Bike();
        v.CalculateRent(5);

        Console.WriteLine();

        v = new Bus();
        v.CalculateRent(8);
    }
}