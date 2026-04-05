using System;

public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        return $"Event ID: {GetEventId()}\n{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}\nStatus: {GetEventStatus()}";
    }

    public string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}