using System;

public class Deliveryservice
{
    public void calculatedeliverycharge(double distance)
    {
        double total = distance * 100;
        Console.WriteLine("Charge: " + total);
    }

    public void calculatedeliverycharge(double distance, double weight)
    {
        double total = distance * weight * 100;
        Console.WriteLine("Charge with weight: " + total);
    }

    public void calculatedeliverycharge(double distance, double weight, string status)
    {
        double total = distance * weight * 100;
        Console.WriteLine("Charge with weight: " + total +" " + "Status: " + status);
        
    }

    public static void Main(string[] args)
    {
        Deliveryservice obj = new Deliveryservice();

        obj.calculatedeliverycharge(56);
        obj.calculatedeliverycharge(56, 6);
        obj.calculatedeliverycharge(56, 6, "Completed");
    }
}