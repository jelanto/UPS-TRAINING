using System;

public class ElectricityBill
{
    int customerId;
    string name="";
    int units;
    double charge;
    double fixedCharge = 50;
    double surcharge = 0;
    double totalBill;

    public void GetDetails()
    {
        Console.Write("Enter Customer ID: ");
        customerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Enter Units Consumed: ");
        units = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateBill()
    {
        if (units <= 100)
        {
            charge = units * 1.5;
        }
        else if (units <= 200)
        {
            charge = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else if (units <= 300)
        {
            charge = (100 * 1.5) + (100 * 2.5)
                     + ((units - 200) * 4);
        }
        else
        {
            charge = (100 * 1.5) + (100 * 2.5)
                     + (100 * 4) + ((units - 300) * 6);
        }

        totalBill = charge + fixedCharge;

        if (totalBill > 1000)
        {
            surcharge = totalBill * 0.05;
        }

        totalBill = totalBill + surcharge;
    }

    public void DisplayBill()
    {
        Console.WriteLine("\n----- ELECTRICITY BILL -----");
        Console.WriteLine("Customer ID: " + customerId);
        Console.WriteLine("Customer Name: " + name);
        Console.WriteLine("Units Consumed: " + units);
        Console.WriteLine("Energy Charge: Rs. " + charge);
        Console.WriteLine("Fixed Charge: Rs. " + fixedCharge);
        Console.WriteLine("Surcharge: Rs. " + surcharge);
        Console.WriteLine("Total Bill: Rs. " + totalBill);

        if (totalBill <= 500)
        {
            Console.WriteLine("Payment Category: Low");
        }
        else if (totalBill <= 1500)
        {
            Console.WriteLine("Payment Category: Medium");
        }
        else
        {
            Console.WriteLine("Payment Category: High");
        }
    }

    public double GetBill()
    {
        return totalBill;
    }
}

public class Electricityrogram
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of customers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double totalRevenue = 0;
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("\nCustomer " + i);

            ElectricityBill customer = new ElectricityBill();

            customer.GetDetails();
            customer.CalculateBill();
            customer.DisplayBill();

            totalRevenue = totalRevenue + customer.GetBill();
            count++;
        }

        Console.WriteLine("\n===== FINAL SUMMARY =====");
        Console.WriteLine("Customers Processed: " + count);
        Console.WriteLine("Total Revenue: Rs. " + totalRevenue);
    }
}