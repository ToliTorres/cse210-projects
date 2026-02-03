using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Programming Full Course with Mini-Projects", "freeCodeCamp.org", 480);
        video1.AddComment(new Comment("@Mayeloski", "Nice to see a C# Course!"));
        video1.AddComment(new Comment("@AdegbengaAgoroCrenet", "The instructor does an amazing job of breaking down the subject matter. I really love his summaries at the end of each video. Exceptional work."));
        video1.AddComment(new Comment("@azmeer_farhan", "Now i can also contribute in developing GTA VI"));
        video1.AddComment(new Comment("@lazarokabira2945", "This channel is just a blessing,all this knowledge for free"));

        Video video2 = new Video("Python Full Course for Beginners", "Programming with Mosh", 120);
        video2.AddComment(new Comment("@oduguwaoluwaseyi3019", "I am close to 60years but I believe age shouldn't be a barrier in learning programming language"));
        video2.AddComment(new Comment("@AmirsamMirzabeigi", "i'm just a teenager and because it's summer i had nothing else to do, so following the advice of my friends i'm learning coding wish me luck"));
        video2.AddComment(new Comment("@KhoaNguyen-kr8cj", "I am start learning Python from today. Python will be my main program language. I will be professional AI engineer someday. Wish me luck"));
        video2.AddComment(new Comment("@plain3808", "Im starting to learn python today! wish me luck"));
        video2.AddComment(new Comment("@odysseus5199", "Iam 40 years old and i am ready for this."));

        Video video3 = new Video("C# abstract classes", "Bro Code", 3);
        video3.AddComment(new Comment("@faycaled3058", "After 2 years of coding I've finally understand what is the purpose of this abstract thanks to you !"));
        video3.AddComment(new Comment("@Fraps224", "your explanations are awesome"));
        video3.AddComment(new Comment("@TXPhoenix79", "This simple explanation is EXACTLY what I was looking for. Thank you."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}