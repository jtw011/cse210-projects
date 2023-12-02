using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video1", "Author1", "Length1"),
            new Video("Video2", "Author2", "Length2"),
            new Video("Video3", "Author3", "length3")
        };

        Comment comment1 = new Comment("User1", "Great video!");
        Comment comment2 = new Comment("User2", "Thanks for sharing!");
        Comment comment3 = new Comment("User3", "Very informative.");
        Comment comment4 = new Comment("User4", "I learned a lot from this video.");
        Comment comment5 = new Comment("User5", "Awesome content!");
        Comment comment6 = new Comment("User6", "Keep it up!");
        Comment comment7 = new Comment("User7", "This video is great!");

    
        videos[0].AddComment(comment1);
        videos[0].AddComment(comment2);
        videos[1].AddComment(comment3);
        videos[1].AddComment(comment4);
        videos[2].AddComment(comment5);
        videos[2].AddComment(comment6);


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLength()}, Number of comments: {video.NumberOfComments()}");
        }
             
             
    }    

}