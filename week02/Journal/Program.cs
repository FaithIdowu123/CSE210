using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        PromptGenerator Prompts = new PromptGenerator();

        List<string> options = new List<string>();
        options.Add("Write");
        options.Add("Display");
        options.Add("Load");
        options.Add("Save");
        options.Add("Exit");


        
        Prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts._prompts.Add("What was the best part of my day?");
        Prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts._prompts.Add("What was the strongest emotion I felt today?");
        Prompts._prompts.Add("If I had one thing I could do over today, what would it be?");


        Console.WriteLine("Welcome to thee Journal Program!");
        string? choice = "0";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            int number = 0;
            foreach (string option in options)
            {
                number += 1;
                Console.WriteLine($"{number}. {option}");
            }
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("");
                string prompt = Prompts.RandomPrompt();
                Console.Write(prompt);
                string? response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                entry._prompt = prompt;
                entry._response = response;
                entry._dateTime = dateText;

                journal._entries.Add(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                journal.DisplayEntries();
                Console.WriteLine("");
            }
            else if (choice == "3")
            {
                Console.WriteLine("");
                Console.Write("What is the name of the file you want to load? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Load successful!");
                Console.WriteLine("");
            }
            else if (choice == "4")
            {
                Console.WriteLine("");
                Console.Write("What is the name of the file that you would like to save your journal? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Save successful!");
                Console.WriteLine("");
            }
            else if (choice == "5")
            {
                Console.WriteLine("");
                Console.WriteLine("Goodbye for now.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry but that is not a valid option.");
            }
        }  
    }
}