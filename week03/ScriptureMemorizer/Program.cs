using System;

class Program
{
    static void Main(string[] args)
    {
        Reference R = new Reference("John", "3", "16");
        Scripture S = new Scripture(R, "For God so loved the world that he gave his only begotten, that whosoever believeth in him shall not die but have everlasting life.");
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
            }
            else if (option == "quit")
            {
                state  = true;
            }
        }
    }
}