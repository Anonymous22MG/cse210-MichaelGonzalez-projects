using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("W 2nd S & S 3rd St W", "Rexburg", "ID", "USA");
        Address address2 = new Address("101 E Viking Dr", "Rexburg", "ID", "USA");
        Address address3 = new Address("433 Airport Rd", "Rexburg", "ID", "USA");

        Lecture lecture = new Lecture(
            "The Psychology of Motivation",
            "An engaging lecture about how habits and mindset influence success.",
            "June 20, 2026",
            "6:00 PM",
            address1,
            "Dr. Emily Carter",
            120
        );

        Reception reception = new Reception(
            "Art Gallery Opening Night",
            "An elegant evening to celebrate local artists and their newest exhibitions.",
            "October 5, 2026",
            "7:45 PM",
            address2,
            "gallery@artspace.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Family Picnic",
            "Join us for a day of games, food, and outdoor fun for all ages.",
            "September 13, 2026",
            "1:00 PM",
            address3,
            "Sunny skies with a gentle breeze"
        );

        Console.WriteLine("LECTURE");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine("RECEPTION");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine("OUTDOOR GATHERING");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoor.GetShortDescription());
    }
}