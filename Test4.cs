using System;

abstract class Person
{
    public int PersonId;
    public string Name="";
    public int Age;

    public abstract void CalculateCharges();

    public void DisplayPersonDetails()
    {
        Console.WriteLine("Person ID: " + PersonId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Doctor : Person
{
    public int ConsultationFee;
    public int NumberOfPatients;

    public override void CalculateCharges()
    {
        int total = ConsultationFee * NumberOfPatients;
        Console.WriteLine("Total Collection: " + total);
    }
}

class Patient : Person
{
    public int RoomCharge;
    public int NumberOfDays;
    public int MedicineCharge;

    public override void CalculateCharges()
    {
        int total = (RoomCharge * NumberOfDays) + MedicineCharge;

        Console.WriteLine("Patient Name: " + Name);
        Console.WriteLine("Room Charge: " + RoomCharge);
        Console.WriteLine("Number of Days: " + NumberOfDays);
        Console.WriteLine("Medicine Charge: " + MedicineCharge);
        Console.WriteLine("Total Hospital Bill: " + total);
    }
}

class Nurse : Person
{
    public int MonthlySalary;
    public int ExtraDutyHours;

    public override void CalculateCharges()
    {
        int total = MonthlySalary + (ExtraDutyHours * 200);
        Console.WriteLine("Total Salary: " + total);
    }
}

class PatientManagementSystem
{
    static void Main()
    {
        Patient p = new Patient();

        p.PersonId = 101;
        p.Name = "Kumar";
        p.Age = 35;
        p.RoomCharge = 2000;
        p.NumberOfDays = 3;
        p.MedicineCharge = 1500;

        p.CalculateCharges();
    }
}