class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
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
        Console.Write($"Breathe in ");
        ShowCountDown(2);
        Console.WriteLine("");
        Console.Write("Breathe out ");
        ShowCountDown(3);
        Console.WriteLine("");
        Console.WriteLine("");

        for (int i = duration; i > 0; i -= 10)
        {
            Console.Write($"Breathe in ");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Breathe out ");
            ShowCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }
}