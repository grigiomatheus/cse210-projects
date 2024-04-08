using Foundation3.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("Lecture on C#", "Learn about C# programming language", new DateTime(2024, 12, 15, 10, 0, 0), new TimeSpan(1, 30, 0), new Address("123 Main St", "New York", "NY", "USA"), "John Doe", 100);
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GenerateShortMessage());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event");
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("Picnic", "Enjoy a picnic in the park", new DateTime(2024, 12, 15, 10, 0, 0), new TimeSpan(1, 30, 0), new Address("123 Main St", "New York", "NY", "USA"), "Sunny");
        Console.WriteLine(outdoorGatheringEvent.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GenerateShortMessage());
        Console.WriteLine();


        Console.WriteLine("Reception Event");
        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding Reception", "Celebrate the marriage of John and Jane", new DateTime(2024, 12, 15, 10, 0, 0), new TimeSpan(1, 30, 0), new Address("123 Main St", "New York", "NY", "USA"), "email@gmail.com");
        Console.WriteLine(receptionEvent.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GenerateShortMessage());
        Console.WriteLine();
    }
}