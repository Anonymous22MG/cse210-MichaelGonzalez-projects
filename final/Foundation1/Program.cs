using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //List of videos
        List<Video> videos = new List<Video>();

        //Video 1
        Video v1 = new Video("C# Basics", "CodeEasy", 700);
        v1.AddComment(new Comment("Michael", "Great explanation!"));
        v1.AddComment(new Comment("Claire", "Very helpful"));
        v1.AddComment(new Comment("Mateo", "I finally understood!"));
        videos.Add(v1);

        //Video 2
        Video v2 = new Video("Principles in C# part 1", "UltimDev", 800);
        v2.AddComment(new Comment("Sebastian", "Nice examples"));
        v2.AddComment(new Comment("Eva", "Loved it!"));
        v2.AddComment(new Comment("Kaden", "Can you do inheritance next?"));
        videos.Add(v2);

        //Video 3
        Video v3 = new Video("Python Basics", "TechMate01", 750);
        v3.AddComment(new Comment("Sofy", "Clear and simple"));
        v3.AddComment(new Comment("David", "Helped a lot"));
        v3.AddComment(new Comment("Emma", "Good pacing"));
        videos.Add(v3);

        //Display
        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}