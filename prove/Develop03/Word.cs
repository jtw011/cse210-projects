using System.IO.Enumeration;

class Word
{

    public string Text { get; }
    public bool IsHidden {get; set;}

    public Word(String text)
    {
        Text = text;
        IsHidden = false;
    }


}