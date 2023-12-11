using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;

public class Video
{
    private string _title;

    private string _author;

    private string _length;

    private List<Comments>_comments = new List<Comments>();

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetLength()
    {
        return _length;
    }

    public Video(string Title, string Author, string Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;


    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comments>GetComments()
    {
        return _comments;
    }


}