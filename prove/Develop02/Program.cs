using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Collections;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        string fileName = "journal.txt";

        if (File.Exists(fileName))
        {
            string[] entries = File.ReadAllLines(fileName);
            journal.Load(entries);
        }

        
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please Select one of the choices:");
        string choice = Console.ReadLine();
        
        switch(choice)
        {
            case "1":
                string randomPrompt = prompt.RandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.WriteLine("Enter your journal entry:");
                string entry = Console.ReadLine();
                journal.AddEntry(entry);
                break;

            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                string[] entries = File.ReadAllLines(fileName);
                journal.Load(entries);
                break;
            case "4":
                journal.SaveToFile(fileName);
                Console.WriteLine($"Journal saved to {fileName}");
                break;
            case "5":
                Environment.Exit(0);
                break;
        }
    }   
    }
}