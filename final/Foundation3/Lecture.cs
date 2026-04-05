using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Event ID: {GetEventId()}\n{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}\nStatus: {GetEventStatus()}";
    }

    public string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}