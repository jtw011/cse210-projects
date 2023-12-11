public class Comments
{
    private string _commenterName;
    private string _text; 

    public Comments(string CommenterName, string Text)
    {
        _commenterName = CommenterName;
        _text = Text;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }

}