using System.IO.Enumeration;

class Word
{

    public string _Text;
    public bool _IsHidden;

    public Word(string text, bool IsHidden)
    {
        _Text = text;
        _IsHidden = false;
    }

    public void display()
    {
        Console.WriteLine(_Text);
    }



}