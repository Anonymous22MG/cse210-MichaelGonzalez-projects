using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("01 Apr 2026", 27, 5.0));
        activities.Add(new Cycling("02 Apr 2026", 45, 17.0));
        activities.Add(new Swimming("03 Apr 2026", 20, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}