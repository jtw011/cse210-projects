public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalDescription, int points, bool goalContinue) : base(goalDescription, points, goalContinue)
    {
        _isComplete = false;
    }

    public override int Record()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            AddPoints(_points);
        }
        return _points;   
    }

    public override void Display()
    {
        base.Display();
        string status = _isComplete ? "Completed" : "Not Completed";

        Console.WriteLine($"{status}");
    }



}