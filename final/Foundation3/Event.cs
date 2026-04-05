using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

//Exceeding Requirement: Each event will be assined an ID automatically and the program will determine if the event is Upcoming, Today, or Past
    private static int _eventCounter = 1;
    private int _eventId;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

        _eventId = _eventCounter;
        _eventCounter++;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public int GetEventId()
    {
        return _eventId;
    }

    public string GetEventStatus()
    {
        DateTime eventDate = DateTime.Parse(_date);

        if (eventDate.Date > DateTime.Now.Date)
        {
            return "Upcoming";
        }
        else if (eventDate.Date < DateTime.Now.Date)
        {
            return "Past";
        }
        else
        {
            return "Today";
        }
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.GetFullAddress()}";
    }
}