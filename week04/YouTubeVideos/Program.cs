using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    // Comment class to track commenter name and text
    class Comment
    {
        public string Name { get; }
        public string Text { get; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }

    // Video class to track title, author, length and comments
    class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int LengthSeconds { get; }

        private List<Comment> comments;

        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("C# Tutorial for Beginners", "Tech Guru", 600);
            Video video2 = new Video("How to Cook Pasta", "Chef Lisa", 420);
            Video video3 = new Video("Top 10 Travel Destinations 2025", "TravelWithMe", 900);

            // Add comments to video 1
            video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful."));
            video1.AddComment(new Comment("Bob", "Could you make a video on advanced topics?"));
            video1.AddComment(new Comment("Charlie", "Thanks for explaining so clearly."));

            // Add comments to video 2
            video2.AddComment(new Comment("David", "Yummy recipe! Tried it today."));
            video2.AddComment(new Comment("Eva", "I love how simple this is."));
            video2.AddComment(new Comment("Frank", "Can you show gluten-free options?"));
            video2.AddComment(new Comment("Grace", "Delicious!"));

            // Add comments to video 3
            video3.AddComment(new Comment("Helen", "Adding these places to my bucket list."));
            video3.AddComment(new Comment("Ian", "Great visuals!"));
            video3.AddComment(new Comment("Judy", "Which destination do you recommend most?"));

            // Store videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Display info for each video
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.Name}: {comment.Text}");
                }

                Console.WriteLine(new string('-', 40));  // separator
            }
        }
    }
}
