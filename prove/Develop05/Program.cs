using System;

class Program
{
    static void Main(string[] args)
    {
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

            Goal goal = null;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Create New Goal");
                    goal = new Goal();
                    break;

                case 2:
                    Console.WriteLine("You selected List Goal");
                    goal = new ReflectingActivity();
                    break;

                case 3:
                    Console.WriteLine("You selected Save Goal");
                    goal = new UserRecord();
                    break;

                case 4:
                    Console.WriteLine("You selected Load Goal");
                    goal = new ListingActivity();
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option");
                    break;
            }

            if (goal != null)
            {
                goal.Start();
                goal.PerformActivity();
                goal.End();
            }

        }
       
        
    }
}