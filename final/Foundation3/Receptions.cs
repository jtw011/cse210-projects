public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

       public override string FullDetails()
    {
        return $"{StandardDetails()}, RSVP Email: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Reception: {GetTitle()}, {GetDate()}"; 
    }
}