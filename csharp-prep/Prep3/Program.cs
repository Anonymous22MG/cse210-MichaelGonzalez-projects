using System;

class Program
{
    static void Main(string[] args)
    {
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
        }
    }
}