using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        Prompt prompt = new Prompt();
        string fileName = "journal.txt";

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

        if (int.TryParse(Console.ReadLine(), out int choice))
        {

            if (choice == 1)
            {
                string randomPrompt = prompt.RandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.WriteLine("Enter your response: ");
                string response = Console.ReadLine();
                Entry entry = new Entry(randomPrompt, response, DateTime.Now);
            }
    
            else if (choice == 2)
            {
                Console.WriteLine("Journal Entries:");
                foreach (var entries in entry)
                {
                    Console.WriteLine($"Date: {entry.Date}");
                    Console.WriteLine($"{entry.Prompt}");
                    Console.WriteLine($"{entry.Response}");
                    Console.WriteLine();
                }
            }

           else if (choice == 3)
           {
                entries = LoadEntriesFromFile(fileName);
           }

           else if (choice == 4)
           {
                SaveEntriesToFile(entries, fileName);
           }

           else if (choice == 5)
           {
                Environment.Exit(0);
           }

           else
           {
            Console.WriteLine("Invalid choice. Please select a valid option");
           }
        }
    }   
    }
}