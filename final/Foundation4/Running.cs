public class Running : Activity
{
     double _distance;

    public Running(DateTime date, double minutes, double distance, string activityName) : base(date, minutes, activityName)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}