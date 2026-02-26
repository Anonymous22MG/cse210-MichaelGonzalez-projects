using System;

class Program
{
/*EXCEEDING REQUIREMENTS: I improved the word-hiding behavior so the program only selects from words that are not already hidden*/
    static void Main(string[] args)
    {
        //store a scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to end: ");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            //hide a few random words each time
            scripture.HideRandomWords(3);
        }
    }
}
