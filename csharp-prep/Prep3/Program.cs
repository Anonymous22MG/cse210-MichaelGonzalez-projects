using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int mnumber = randomGenerator.Next(1, 101);
            int guessCount = 0;

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;

            while (guess != mnumber)
            {
                if (guess > mnumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}

