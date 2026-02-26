using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.Write("What is the magic number? ");
        int mnumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess!= mnumber)
        {
            if (guess > mnumber)
            {
                Console.WriteLine("Lower");
            }else if (guess< mnumber)
            {
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("You guessed it!");
            }
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
=======
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
>>>>>>> 83839d2e612c4a950a3511208ed16c6a4076d47c
        }
    }
}

