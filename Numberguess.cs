using System;

public class Numberguess
{
    public static void Main(String[] args)
    {
        Random random = new Random();
        String play = "yes";

        while (play == "yes")
        {
            int num = random.Next(1, 101);
            int attempts = 0;
            int maxattempts = 3;
            int score = 0;
            int guess = 0;

            Console.WriteLine("Enter a number between 1 and 100. You have 3 attempts:");

            while (attempts < maxattempts)
            {
                Console.WriteLine("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Enter a valid number between 1 and 100");
                    continue;
                }

                attempts++;

                if (guess == num)
                {
                    Console.WriteLine("You won!!!");
                    score = (maxattempts - attempts + 1) * 100;
                    break;
                }
                else if (guess > num)
                {
                    Console.WriteLine("Too High!!!");
                }
                else
                {
                    Console.WriteLine("Too Low!!!");
                }

                Console.WriteLine("Attempts left: " + (maxattempts - attempts));
            }

            if (guess != num)
            {
                Console.WriteLine("You lost!!!");
                Console.WriteLine("Correct number: " + num);
            }

            Console.WriteLine("Attempts used: " + attempts);
            Console.WriteLine("Score: " + score);

            Console.Write("Play again? (yes/no): ");
            play = Console.ReadLine()??"".Trim().ToLower();

            while (play != "yes" && play != "no")
            {
                Console.Write("Enter yes or no: ");
                play = Console.ReadLine()??"".Trim().ToLower();
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}