class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description) : base(name, description)
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

        Console.WriteLine("Consider the folowing prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue.\n\b");
        string C = Console.ReadLine();
        Console.WriteLine("Now ponder on each of thee following questions as their related to the experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        Console.Clear();

        for (int i = duration; i > 0; i -= 5)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine("");
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        Random rand = new Random();
        int number = rand.Next(1, prompts.Count());
        return prompts[number];
    }

    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>();

        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        Random rand = new Random();
        int number = rand.Next(1, questions.Count());
        return questions[number];
    }
}