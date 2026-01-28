using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial", "John Doe", 600,0);
        Video video2 = new Video("Learn Python", "Jane Smith", 750,0);
        Video video3 = new Video("Java Basics", "Mike Johnson", 500,0);
        Video video4 = new Video("Web Development", "Emily Davis", 800,0);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I love this video!"));
        video2.AddComment(new Comment("David", "Awesome content!"));
        video3.AddComment(new Comment("Eve", "Well explained."));
        video1.AddComment(new Comment("Grace", "This cleared up a lot of confusion."));
        video2.AddComment(new Comment("Heidi", "Can't wait for more videos like this."));
        video2.AddComment(new Comment("Ivan", "Super informative."));
        video3.AddComment(new Comment("Judy", "Thanks for sharing!"));
        video2.AddComment(new Comment("Kevin", "This was exactly what I needed."));
        video3.AddComment(new Comment("Laura", "Fantastic presentation."));
        video3.AddComment(new Comment("Mallory", "Learned a lot from this."));
        video4.AddComment(new Comment("Niaj", "Very detailed explanation."));
        video4.AddComment(new Comment("Olivia", "Helped me understand the topic better."));
        video4.AddComment(new Comment("Peggy", "Excellent video!"));
        video4.AddComment(new Comment("Frank", "Looking forward to more videos."));
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
        }

    }
}