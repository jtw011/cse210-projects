public class ChecklistGoal : Goal
{
    private List<string> _checklist;

    private int _target;

    private int _timesDone;

    private int _bonusPoints;

    public ChecklistGoal(string goalDescription, int points, bool goalContinue, int target, int timesDone, int bonusPoints) : base(goalDescription, points, goalContinue)
    {
        _checklist = new List<string>();
        _timesDone = 0;
        _bonusPoints = bonusPoints;
        _target = target;
    }

    public override int Record()
    {
        _timesDone++;
        if (_timesDone >= _target)
        {
            AddPoints(_points + _bonusPoints);
        }
        else
        {
            AddPoints(_points);
        }
        return _points;
    }

    public void displayChecklist()
    {
        for (int i = 0; i < _checklist.Count; i++)
        {
            string status = i < _timesDone ? "Completed" : "Not Completed";
            Console.WriteLine($"{_checklist[i]}: {status}"); 
        }
    }
}
