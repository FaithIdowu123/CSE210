class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done.");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of this activity.");
        ShowSpinner(5);
    }


    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");

        while (seconds > 0)
        {
            foreach (string spin in spinner)
            {
                Console.Write(spin);
                Thread.Sleep(500);
                Console.Write("\b \b");
                seconds -= 1;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 9)
            {
                Console.Write("\b \b\b \b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}