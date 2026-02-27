using System;

public class BreathingActivity : Activity
{
    //Attributes
    private int _inhaleSeconds;
    private int _exhaleSeconds;

    //Constructor
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    {
        _inhaleSeconds = 4;
        _exhaleSeconds = 6;
    }

    //Behavior
    protected override void DoActivity()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Begin breathing...\n");

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(_inhaleSeconds);
            Console.WriteLine();

            if (DateTime.Now >= endTime)
                break;

            Console.Write("Breathe out... ");
            ShowCountdown(_exhaleSeconds);
            Console.WriteLine();
        }
    }
}