//For my exceeding the requirements, I created a new txt and cs class file file with a few scriptures,
//and made it so that the program randomly selects one of the scripture for the user to memorize.
// I also made it so that the scripture re-apeaper, when all the words are hidden,
// in order for the user to check if they were able to memorize it.
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Bible bible = new Bible();
        foreach (var line in File.ReadLines("bible.txt"))
        {
            var parts = line.Split("|");
            bible.SetReference(parts[0]);
            bible.SetScripture(parts[1]);
        }
        int total = bible.GetTotal();
        Random ran = new Random();
        int choice = ran.Next(0, total);

        string reference = bible.GetReference(choice);
        string scripture = bible.GetScripture(choice);

        var part = reference.Split(" ");
        string book = part[0];

        string v = part[1];
        var p = v.Split(":");

        string chapter = p[0];
        string verses = p[1];

        Reference R = new Reference(book, chapter, verses);
        Scripture S = new Scripture(R, scripture);
        bool state = false;
        while (state == false)
        {
            Console.Clear();
            string text = S.GetDisplayText();
            Console.WriteLine(text);

            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string option = Console.ReadLine();
            if (option == "")
            {
                state = S.IsCompletelyHidden();
                if (state == false)
                {
                    S.HideRandomWords(2);
                }
                else
                {
                    Console.Clear();
                    text = S.GetDisplayText();
                    Console.WriteLine(text);
                }
            }
            else if (option == "quit")
            {
                state = true;
            }
        }
    }
}