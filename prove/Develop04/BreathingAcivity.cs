using System;
using System.Threading;
public class BreathingActivity : Activity
{
    private string[] prompts;
    public BreathingActivity()
    {
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        prompts= new string[] {"Breathe in...", "Breathe out..."};

    }

    public override void PerformActivity()
    {
        int promptIndex = 0;
        while (duration > 0)
        {
            Console.WriteLine(prompts[promptIndex]);
            promptIndex = 1 - promptIndex;
            AnimatePause(1);
            duration--;
        }
    }
}