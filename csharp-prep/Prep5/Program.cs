using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string savedname = PromptUserName();
        int savednumber = PromptUserNumber();
        int savedbyear;
        PromtUserBirthYear(out savedbyear);
        int savedsnumber = SquareNumber(savednumber);
        DisplayResult(savedname, savedsnumber, savedbyear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int snumber = number*number;
        return snumber;
    }

    static void DisplayResult(string name, int snumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {snumber}");
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

}