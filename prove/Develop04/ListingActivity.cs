using System.ComponentModel;

public class ListingActivity : Activity
{
    private string[] prompts;
    public ListingActivity()
    {
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month",
            "Who are some of your personal heroes?"
        };
    }

    public override void PerformActivity()
    {
        while (duration > 0)
        {
            Console.WriteLine("Think about: " + prompts[new Random().Next(prompts.Length)]);
            Console.WriteLine("You can start listing items now...");
            AnimatePause(duration);
            Console.WriteLine("Number of items entered: " +duration);
        }
    }
    
}