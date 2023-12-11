using System;
using System.ComponentModel;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("111 Main St", "Rexburg", "ID", "USA");

        Lectures lectures = new Lectures("Lecture 1", "Description 1", DateTime.Now, TimeSpan.FromHours(2), address, "Speaker 1", 100);

        Receptions reception = new Receptions("Reception 1", "description 1", DateTime.Now, TimeSpan.FromHours(2), address, "example@email.com");

        Outdoor outdoor = new Outdoor("Outdoor 1", "Description 1", DateTime.Now, TimeSpan.FromHours(2), address, "sunny");

        Console.WriteLine($"Lecture: {lectures.FullDetails()}, {lectures.ShortDescription()}");
        Console.WriteLine($"Reception: {reception.FullDetails()}, {reception.ShortDescription()}");
        Console.WriteLine($"Lecture: {outdoor.FullDetails()}, {outdoor.ShortDescription()}");
        }
}