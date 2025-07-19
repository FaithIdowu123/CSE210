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
        V1._length = "35:08";

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
        V2._length = "19:35";

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
        V3._length = "2:21";

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
        V4._title = "";
        V4._author = "";
        V4._length = "";



    }
}