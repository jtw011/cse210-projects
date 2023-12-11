public class Outdoor : Event
{
    private string _weatherForcast;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForcast) : base(title, description, date, time, address)
    {
        _weatherForcast = weatherForcast;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}, Forecast: {_weatherForcast}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor: {GetTitle()}, {GetDate()}"; 
    }

}