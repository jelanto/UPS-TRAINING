using System;

public static class Quadratic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter c:");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("a cannot be zero.");
        }
        else
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("Root 1 = " + root1);
                Console.WriteLine("Root 2 = " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);

                Console.WriteLine("Both roots are equal: " + root);
            }
            else
            {
                Console.WriteLine("Roots are imaginary.");
            }
        }
    }
}