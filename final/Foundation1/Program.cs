using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("C# Basics", "CodeMaster", 600);
        v1.AddComment(new Comment("Michael", "Great explanation!"));
        v1.AddComment(new Comment("Ana", "Very helpful."));
        v1.AddComment(new Comment("Luis", "I finally understood classes."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("OOP in C#", "DevPro", 800);
        v2.AddComment(new Comment("Carlos", "Nice examples."));
        v2.AddComment(new Comment("Maria", "Loved it!"));
        v2.AddComment(new Comment("John", "Can you do inheritance next?"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Abstraction Explained", "TechGuru", 500);
        v3.AddComment(new Comment("Sofia", "Clear and simple."));
        v3.AddComment(new Comment("David", "Helped a lot."));
        v3.AddComment(new Comment("Emma", "Good pacing."));
        videos.Add(v3);

        // Mostrar todos los videos
        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}