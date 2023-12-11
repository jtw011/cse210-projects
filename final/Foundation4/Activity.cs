public abstract class Activity
{
    protected DateTime _date;
    protected double _minutes;
    protected string _ActivityName;

    public Activity(DateTime date, double minutes, string ActivityName)
    {
        _date = date;
        _minutes = minutes;
        _ActivityName = ActivityName;
    }

    public DateTime GetDate()
    {
        return _date;
    }


    public double Getminutes()
    {
        return _minutes;
    }

    public string GetActivityname()
    {
        return _ActivityName;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {_ActivityName} - ({_minutes} min)";
    }

}