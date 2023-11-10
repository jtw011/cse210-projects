using System.ComponentModel;

public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        description = "This activity will help your reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void PerformActivity()
    {
        Console.WriteLine("Reflect on your Strengths and resilience...");
        AnimatePause(duration);
    }
}