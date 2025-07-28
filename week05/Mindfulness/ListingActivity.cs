using System.Security.Cryptography;

class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("How long, in seconds, would you like for your session? ");
        string answer = Console.ReadLine();
        int duration = int.Parse(answer);
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine("Get Ready....");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("List as many responses as you can to the prompt:");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        Console.WriteLine("");

        List<string> responses = new List<string>();
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(duration);
        while (now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            now = DateTime.Now;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {responses.Count()} times.");
        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        Random randomGenerator = new Random();
        int rand = randomGenerator.Next(1, prompts.Count());
        string prompt = prompts[rand];
        return prompt;
    }

}