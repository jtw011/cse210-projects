using System;
using System.ComponentModel;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        UserRecord userRecord = new UserRecord(0, "myFile.txt");
        userRecord.makeList();

         while (true)
        {
            Console.WriteLine("You have {points} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goal");
            Console.WriteLine("  3. Save Goal");
            Console.WriteLine("  4. Load Goal");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            Console.ReadLine();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    

                    Console.WriteLine("Enter the description of the goal: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter the points for the goal: ");
                    int points = int.Parse(Console.ReadLine());

                    Console.WriteLine("is this a continuous goal? (y/n)");
                    bool isContinuous = Console.ReadLine().ToLower() == "y";

                    Console.WriteLine("What type of goal is this? (simple, checklist or eternal)");
                    string goalType = Console.ReadLine().ToLower();

                    Goal newGoal;

                    switch (goalType)
                    {
                    
                        case "simple":
                        newGoal = new SimpleGoal(description, points, isContinuous);
                        break;

                        case "checklist":
                        Console.WriteLine("Enter the number of times this goal needs to be completed: ");
                        int target = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the current progress towards the goal: ");
                        int current = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the bonus points for the goal: ");
                        int bonus = int.Parse(Console.ReadLine());

                        Goal newGoal = new ChecklistGoal(description, points, isContinuous, target, current, bonus);
                        break;

                        case "eternal":
                        Goal newGoal = new EternalGoal(description, points, isContinuous);
                        break;

                        default:
                        Console.WriteLine("Invalid goal type.");
                        break;

                    }
                    if (newGoal != null)
                    {

                        userRecord.CreateGoal(newGoal);
                        Console.WriteLine("Goal Successfully created!");
                    }

                case 2:
                    Console.WriteLine("You selected List Goal");
                    userRecord.Display();
                    break;

                case 3:
                    Console.WriteLine("You selected Save Goal");
                    userRecord.SaveGoals();
                    break;

                case 4:
                    Console.WriteLine("You selected Load Goal");
                    userRecord.loadGoals();
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option");
                    break;
            }

        }
       
        
    }
}