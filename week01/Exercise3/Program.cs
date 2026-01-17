using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        // Loop to allow playing multiple games
        while (playAgain.ToLower() == "yes")
        {
            // Create a random number generator
            Random randomGenerator = new Random();

            // Pick a magic number
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Guess the magic number!");
            Console.WriteLine("I have picked a magic number between 1 and 100.");

            //Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higuer");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
        
    }
}