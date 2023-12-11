using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("11 Dec 2023"), 30, 3.0, "Morning Run"),

            new Cycling (DateTime.Parse("11 Dec 2023"), 30, 20.0,"Bike Ride"),

            new Swimming(DateTime.Parse("11 Dec 2023"), 30, 20,"Swim"),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}