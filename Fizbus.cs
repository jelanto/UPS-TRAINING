using System;
public class FizBus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter thye number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FizBus");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fiz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Bus");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}
        