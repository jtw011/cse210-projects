public class Cycling : Activity
{
    public double _speed;

    public Cycling(DateTime date, double minutes, double speed, string activityName) :base(date, minutes, activityName)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60 * _minutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}