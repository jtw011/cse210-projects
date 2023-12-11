public class Swimming : Activity
{
    public int _laps;

    public Swimming(DateTime date, double minutes, int laps, string activityName) : base(date, minutes, activityName)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 /1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

}