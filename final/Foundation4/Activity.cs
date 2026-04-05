using System;

//Exceeding Requirement: calorie calculation for each activity based on the duration.

public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual double GetCaloriesBurned()
    {
        return 0;
    }

    public virtual string GetName()
    {
        return "Activity";
    }

    public string GetSummary()
    {
        return $"{_date} {GetName()} ({_minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile, Calories Burned: {GetCaloriesBurned():F0}";
    }
}