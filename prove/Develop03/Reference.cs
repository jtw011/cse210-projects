class Reference
{
public string _book;
public int _chapter;
public int _StartVerse;
public int _EndVerse;
public Reference (string book, int chapter, int StartVerse, int EndVerse)
{
    _book = book;
    _chapter = chapter;
    _StartVerse = StartVerse;
    _EndVerse = EndVerse;
}

    public void Display()
    {
        Console.Write($"Book: {_book} Chapter: {_chapter} Verse: {_StartVerse}{_EndVerse}");
    }
}