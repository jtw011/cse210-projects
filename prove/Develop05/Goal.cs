public abstract class Goal
{
   protected string _goalDescription;

   protected int _points;

   protected bool _goalContinue;

   public Goal(string goalDescription, int points, bool goalContinue)
   {
     _goalDescription = goalDescription;
     _points = points;
     _goalContinue = goalContinue;
   }

   public void AddPoints(int pointsToAdd)
   {
    _points += pointsToAdd;
   }

   public virtual void Display()
   {
    Console.WriteLine($"Goal Description: {_goalDescription}");
    Console.WriteLine($"Points: {_points}");
    Console.WriteLine($"{_goalContinue}");
   }

   public abstract int Record();
}