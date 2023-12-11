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

        Comments comment1 = new Comments("User1", "Great video!");
        Comments comment2 = new Comments("User2", "Thanks for sharing!");
        Comments comment3 = new Comments("User3", "Very informative.");
        Comments comment4 = new Comments("User4", "I learned a lot from this video.");
        Comments comment5 = new Comments("User5", "Awesome content!");
        Comments comment6 = new Comments("User6", "Keep it up!");
        Comments comment7 = new Comments("User7", "This video is great!");

    
        videos[0].AddComment(comment1);
        videos[0].AddComment(comment2);
        videos[1].AddComment(comment3);
        videos[1].AddComment(comment4);
        videos[2].AddComment(comment5);
        videos[2].AddComment(comment6);


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLength()}, Number of comments: {video.NumberOfComments()}");
        

        foreach (var comment in video.GetComments())
        {
            Console.WriteLine($"{comment.GetCommenterName()} {comment.GetText()}");
        }
             
        }     
    }    

}