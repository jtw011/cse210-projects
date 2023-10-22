class Reference
{
public string Book {get; }
public int Chapter {get; }
public int StartVerse {get;}
public int EndVerse {get;}
public Reference (string reference)
{
    var parts = reference.Split(':');
    Book = parts[0];
    var verseParts = parts[1].Split('-');
    Chapter = int.Parse(verseParts[0]);
    StartVerse = int.Parse(verseParts[1]);
    EndVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : StartVerse;
}

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}: {StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}: {StartVerse}-{EndVerse}";
        }
    }
}