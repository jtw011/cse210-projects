using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflecting Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Exit");
            Console.WriteLine("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Selected the Breathing Activity");
                    activity = new BreathingActivity();
                    break;

                case 2:
                    Console.WriteLine("You selected Reflecting Activity");
                    activity = new ReflectingActivity();
                    break;

                case 3:
                    Console.WriteLine("You selected Listing Activity");
                    activity = new ListingActivity();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option");
                    break;
            }

            if (activity != null)
            {
                activity.Start();
                activity.PerformActivity();
                activity.End();
            }

        }
   }
}
 