using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;

public class Video
{
    private string _title;

    private string _author;

    private string _length;

    private List<Comment>comments = new List<Comment>();

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

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }


}