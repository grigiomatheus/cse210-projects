using Foundation1.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video_1 = new Video("How to make a delicius cake", "JhonattanMartins", 200);
        video_1.AddComment(new Comment("Random123", "Really good video."));
        video_1.AddComment(new Comment("Matthew", "I enjoy it!"));
        video_1.AddComment(new Comment("John", "I dont like it."));
        video_1.AddComment(new Comment("Luke", "Great job!"));

        Video video_2 = new Video("How to fix your newtwork", "Mark123", 150);
        video_2.AddComment(new Comment("Harry", "This helps me a lot."));
        video_2.AddComment(new Comment("JohnMayer", "Saved my life."));
        video_2.AddComment(new Comment("Elijah", "It doesnt work for me :("));
        video_2.AddComment(new Comment("Ramon", "Thanks!!"));

        Video video_3 = new Video("How to make a delicius cake", "LukeT", 200);
        video_3.AddComment(new Comment("Erika", "Really good video."));
        video_3.AddComment(new Comment("ChristianGonzales", "I enjoy it!"));
        video_3.AddComment(new Comment("WinterJohn", "I dont like it."));
        video_3.AddComment(new Comment("ChadChristofferson", "Great job!"));

        Video video_4 = new Video("Pranking my brother", "Susan", 60);
        video_4.AddComment(new Comment("LanaMatias", "Hahaha so funny!"));
        video_4.AddComment(new Comment("Edward", "LOL"));
        video_4.AddComment(new Comment("Eloah", "Jajajajaja"));
        video_4.AddComment(new Comment("Suzy", "The face he made was hilarious."));

        videos.Add(video_1);
        videos.Add(video_2);
        videos.Add(video_3);
        videos.Add(video_4);

        videos.ForEach(video => video.DisplayInfo());
    }
}