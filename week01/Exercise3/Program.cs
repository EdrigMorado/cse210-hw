using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string playAgain = "yes";

        // Play again logic
        while (playAgain == "yes")
        {
            // Generate random number 
            int randomNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int tries = 0;

            // Enter the loop
            while (guess != randomNumber)
            {
                // Ask user for a number
                Console.Write("What is your guess ? ");
                guess = int.Parse(Console.ReadLine());

                tries++;

                // Main loop logic
                if (guess < randomNumber)
                {
                    Console.WriteLine("Go higher");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Go lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {tries} guesses");
                }
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}