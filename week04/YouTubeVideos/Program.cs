using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learning C# Classes",
            "Code Academy",
            420
        );

        video1.AddComment(
            new Comment("Maria", "This video was very helpful.")
        );

        video1.AddComment(
            new Comment("Carlos", "I finally understand classes.")
        );

        video1.AddComment(
            new Comment("Ana", "Great explanation!")
        );

        Video video2 = new Video(
            "Introduction to Cybersecurity",
            "Secure Tech",
            600
        );

        video2.AddComment(
            new Comment("David", "Excellent introduction.")
        );

        video2.AddComment(
            new Comment("Laura", "Can you make a video about web security?")
        );

        video2.AddComment(
            new Comment("John", "The explanation was very clear.")
        );

        Video video3 = new Video(
            "How to Build a Website",
            "Web Learning",
            750
        );

        video3.AddComment(
            new Comment("Robert", "This helped me with my assignment.")
        );

        video3.AddComment(
            new Comment("Emily", "Great tutorial!")
        );

        video3.AddComment(
            new Comment("Michael", "I learned a lot from this video.")
        );

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine(
                $"Number of comments: {video.GetCommentCount()}"
            );

            Console.WriteLine();
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetName()}: {comment.GetText()}"
                );
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}