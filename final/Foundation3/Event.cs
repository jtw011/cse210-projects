public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public TimeSpan GetTime()
    {   
        return _time;
    }



    public virtual string StandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public virtual string FullDetails()
    {
        return $"{StandardDetails()}";
    }
    public virtual string ShortDescription()
    {
        return $"{StandardDetails()}";
    }
}