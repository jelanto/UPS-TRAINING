using System;

public class SecretCodeBreaker
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        string play = "yes";

        while (play == "yes")
        {
            int code = random.Next(1000, 10000);
            string secret = code.ToString();

            int attempts = 0;
            int maxAttempts = 3;
            int score = 0;
            bool cracked = false;

            Console.WriteLine("\nWelcome to Secret Code Breaker!");
            Console.WriteLine("Guess the 4-digit code.");
            Console.WriteLine("You have 3 attempts.");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine() ?? "";

                if (input.Length != 4)
                {
                    Console.WriteLine("Enter exactly 4 digits.");
                    continue;
                }

                int valid = 1;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                    {
                        valid = 0;
                        break;
                    }
                }

                if (valid == 0)
                {
                    Console.WriteLine("Enter digits only.");
                    continue;
                }

                attempts++;

                int correct = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (input[i] == secret[i])
                    {
                        correct++;
                    }
                }

                if (input == secret)
                {
                    Console.WriteLine("Congratulations! You cracked the code!");
                    score = (maxAttempts - attempts + 1) * 10;
                    cracked = true;
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Correct digits in correct positions: " + correct);

                    Console.WriteLine(
                        "Attempts remaining: " + (maxAttempts - attempts));
                }
            }

            if (cracked == false)
            {
                Console.WriteLine("You could not crack the code!");
                Console.WriteLine("Secret code was: " + secret);
            }

            Console.WriteLine("Attempts used: " + attempts);
            Console.WriteLine("Your score: " + score);

            Console.Write("Do you want to try a new code? (yes/no): ");
            play = (Console.ReadLine() ?? "").Trim().ToLower();

            while (play != "yes" && play != "no")
            {
                Console.Write("Please enter yes or no: ");
                play = (Console.ReadLine() ?? "").Trim().ToLower();
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}