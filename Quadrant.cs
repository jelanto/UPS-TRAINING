using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter X:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Y:");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("1st Quadrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2nd Quadrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3rd Quadrant");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("4th Quadrant");
        }
        else
        {
            Console.WriteLine("Point lies on X-axis, Y-axis, or Origin");
        }
    }
}