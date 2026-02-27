using System;
using System.Threading;

public class Activity
{
    //private for encapsulation
    private string _name;
    private string _description;
    private int _duration;

    //Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        DoActivity();           
        DisplayEndingMessage();
    }

    protected virtual void DoActivity()
    {
    }

    //start message for all activities
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        _duration = PromptForDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    //ending message for all activities
    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }

    // Ask user for duration
    private int PromptForDuration()
    {
        int seconds = 0;

        while (seconds <= 0)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();

            bool ok = int.TryParse(input, out seconds);

            if (!ok || seconds <= 0)
            {
                Console.WriteLine("Please enter a positive whole number.");
                seconds = 0;
            }
        }

        return seconds;
    }

    //derived classes - use the duration
    protected int GetDuration()
    {
        return _duration;
    }

    // Spinner animation
    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }

    // Countdown animation
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}