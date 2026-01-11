using System;

class Program
{
    static void Main(string[] args)
    {

        string sign = "";
        string input;
        string letter = "";
        int lastDigit;

        Console.Write("What is your grade percentage? ");
        input = Console.ReadLine();
        int percentage = int.Parse(input);


        if (percentage>=90)
        {letter= "A";}
        else if (percentage>=80)
        {letter= "B";}
        else if (percentage>=70)
        {letter= "C";}
        else if (percentage>=60)
        {letter= "D";}
        else
        {letter= "F";}

        //getting the sign
        int tens = percentage / 10;
        lastDigit = percentage - (tens * 10);
        

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        //A and F cases
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage>=70)
        {        Console.WriteLine("You passed!");}
        else
        {        Console.WriteLine("Better luck next time!");}
    }
}