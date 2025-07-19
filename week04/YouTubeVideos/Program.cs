using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> Videos = new List<Video>();

        Video V1 = new Video();
        V1._title = "Unreal Engine 5 vs Unity 6";
        V1._author = "samyam";
        V1._length = "2108 seconds";

        Comment V1C1 = new Comment();
        V1C1._commentor = "@future34andpast";
        V1C1._comment = "I'm just a game maker user but i'm watching this video anyways.";
        V1._comments.Add(V1C1);

        Comment V1C2 = new Comment();
        V1C2._commentor = "@GeorgeMice";
        V1C2._comment = "Unity made big improvement ever since the new CEO";
        V1._comments.Add(V1C2);

        Comment V1C3 = new Comment();
        V1C3._commentor = "@ChiragAshiya74927";
        V1C3._comment = "Best comparsion video for unity 6 and unreal 5 on youtube";
        V1._comments.Add(V1C3);

        Comment V1C4 = new Comment();
        V1C4._commentor = "@grimsasin";
        V1C4._comment = "This is an amazing video for both engines details, thanks Samyam";
        V1._comments.Add(V1C4);

        Videos.Add(V1);

        Video V2 = new Video();
        V2._title = "No video today... There is no game";
        V2._author = "BeckBroPlays";
        V2._length = "1175 seconds";

        Comment V2C1 = new Comment();
        V2C1._commentor = "@salmonstick2378";
        V2C1._comment = "Who else new he was gonna play a game before they clicked?";
        V2._comments.Add(V2C1);

        Comment V2C2 = new Comment();
        V2C2._commentor = "@Coda3010";
        V2C2._comment = "There is no game is prob one of the funnest looking games I've ever seen youtubers play.";
        V2._comments.Add(V2C2);

        Comment V2C3 = new Comment();
        V2C3._commentor = "@AoMadeluka";
        V2C3._comment = "I am allergic to grass";
        V2._comments.Add(V2C3);

        Comment V2C4 = new Comment();
        V2C4._commentor = "@JacksonGarrison-Ip6cn";
        V2C4._comment = "It is 19 minutes I checked when I clicked I did not get fooled";
        V2._comments.Add(V2C4);

        Videos.Add(V2);

        Video V3 = new Video();
        V3._title = "Software engineer interns on theiir first day be like...";
        V3._author = "Frying Pan";
        V3._length = "141 seconds";

        Comment V3C1 = new Comment();
        V3C1._commentor = "@chixenlegjo";
        V3C1._comment = "The most difficult part of programming isn't solving problems, it's understanding the task";
        V3._comments.Add(V3C1);

        Comment V3C2 = new Comment();
        V3C2._commentor = "@samuelmiller";
        V3C2._comment = "C hashtag, that's exactly how it's pronounced";
        V3._comments.Add(V3C2);

        Comment V3C3 = new Comment();
        V3C3._commentor = "@lordprime.12";
        V3C3._comment = "As a guy who doesn't know a thing about software engineering. I can relate";
        V3._comments.Add(V3C3);

        Comment V3C4 = new Comment();
        V3C4._commentor = "@Elca_Gaming";
        V3C4._comment = "C Hahtag had me dying";
        V3._comments.Add(V3C4);

        Videos.Add(V3);

        Video V4 = new Video();
        V4._title = "Coding Interviews Be Like";
        V4._author = "Nicholas T.";
        V4._length = "330 seconds";

        Comment V4C1 = new Comment();
        V4C1._commentor = "@AverageSensei";
        V4C1._comment = "7 interviews later: Yeah, we don't think you are the right fit for this positon";
        V4._comments.Add(V4C1);

        Comment V4C2 = new Comment();
        V4C2._commentor = "@peacelover6455";
        V4C2._comment = "Don't forget the part where they say 'Good, now we'll move on to a hard problem'";
        V4._comments.Add(V4C2);

        Comment V4C3 = new Comment();
        V4C3._commentor = "@kevinpark4251";
        V4C3._comment = "As a average person, idk know wwhat he's talking about";
        V4._comments.Add(V4C3);

        Comment V4C4 = new Comment();
        V4C4._commentor = "@Jokamutta";
        V4C4._comment = "I thought it would end like 'Thanks for fixing our coding problem. Thanks, bye!'";
        V4._comments.Add(V4C4);

        Videos.Add(V4);
        foreach (Video video in Videos)
        {
            video.DisplayVideo();
        }
    }
}