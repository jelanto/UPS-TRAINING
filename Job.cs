using System;
using System.Numerics;

public class Job
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Apti Marks:");
        int aptimarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Tech Marks:");
        int techmarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the HR Marks:");
        int hrmarks = Convert.ToInt32(Console.ReadLine());
        int total = aptimarks+techmarks+hrmarks;
        if(aptimarks > 70)
        {
            if(techmarks > 80)
            {
                if(hrmarks > 80){

                    if(total >= 230)
                    {
                        Console.WriteLine("Congrats!U are Selected");
                        if(total >= 280 && total <= 300)
                        {
                            Console.WriteLine("salary = 25,000");
                        }
                        else if(total >= 250 && total <= 280)
                        {
                            Console.WriteLine("salary = 20,000");
                        }
                        else
                        {
                            Console.WriteLine("salary = 15,000");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry!U are Not Selected");   
                    }
                }
                else
                {
                    Console.WriteLine("Your Hr Score is too low"); 
                }
            }
            else
            {
                Console.WriteLine("Your tech Score is too low");
            }
        }
        else
        {
            Console.WriteLine("Your Apti Score is too low");
        }
    }
}