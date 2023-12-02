public class EternalGoal :Goal
{
   private int _time;

   public EternalGoal(string goalDescription, int points, bool goalContinue, int time): base(goalDescription, points, goalContinue)
   {
    _time = time;
   }

   public override int Record()
   {
        _time++;
        AddPoints(_points);
        return _points;
   }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Time: {_time}");
    }

}