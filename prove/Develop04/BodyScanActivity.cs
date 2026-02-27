using System;
using System.Collections.Generic;

public class BodyScanActivity : Activity
{
    private List<string> _steps;

    public BodyScanActivity()
        : base(
            "Body Scan",
            "This activity will guide you through relaxing different parts of your body. Focus on each area and release tension as you breathe slowly."
          )
    {
        _steps = new List<string>()
        {
            "Focus on your forehead and eyes. Relax them.",
            "Relax your jaw and tongue.",
            "Lower your shoulders and release tension.",
            "Notice your chest rising and falling.",
            "Relax your arms, elbows, and hands.",
            "Soften your stomach and breathe.",
            "Relax your hips and thighs.",
            "Release tension in your knees and calves.",
            "Relax your ankles and feet.",
            "Scan your whole body and let go."
        };
    }

    protected override void DoActivity()
    {
        int duration = GetDuration();

        Console.WriteLine("Begin your body scan...\n");

        int timePerStep = duration / _steps.Count;

        // minimum time so it doesn't go too fast
        if (timePerStep < 3)
        {
            timePerStep = 3;
        }

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        foreach (string step in _steps)
        {
            if (DateTime.Now >= endTime)
                break;

            Console.WriteLine(step);
            ShowSpinner(timePerStep);
            Console.WriteLine();
        }
    }
}