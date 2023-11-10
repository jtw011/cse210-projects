using System.Xml.Serialization;

public abstract class Activity
{
    protected int duration;
    protected string description;

    public Activity()
    {
        duration = 0;
        description = "default description";
    }

    public void Start()
    {
        Console.WriteLine("Activity: " + this.GetType().Name);
        Console.WriteLine(description);
        Console.WriteLine("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        System.Threading.Thread.Sleep(2000);
    }

    public abstract void PerformActivity();
    
    public void End()
    {
        Console.WriteLine("You did a grat job!");
        Console.WriteLine("Activity completed: " + this.GetType().Name);
        Console.WriteLine("Duration: " + duration + " seconds");
        AnimatePause(2);
    }

    protected void AnimatePause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("  .  ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}